using eGaraz.Controllers;
using eGaraz.Enums;
using eGaraz.Models;
using eGaraz.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eGarazTests
{
    [TestFixture]
    public class AccountControllerTests
    {
        private DbContextOptions<AppDbContext> options;

        private Mock<FakeUserManager> userManager = new Mock<FakeUserManager>();

        private Mock<FakeSignInManager> signInManager = new Mock<FakeSignInManager>();

        [SetUp]
        public void Setup()
        {
            options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            userManager.Setup(s => s.CreateAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
                            .ReturnsAsync(IdentityResult.Success);
        }

        #region Register
        [Test]
        public void Returns_Account_Register_Page_When_User_Is_Not_Signed_In_HttpGet_RegisterTest()
        {
            signInManager.Setup(s => s.IsSignedIn(It.IsAny<ClaimsPrincipal>()))
                .Returns(false);

            var accountController = new AccountController(userManager.Object, signInManager.Object);

            var result = accountController.Register();

            Assert.That(result is ViewResult);
        }

        [Test]
        public void Redirect_To_Dashboard_Index_When_User_Is_Already_Signed_In_HttpGet_RegisterTest()
        {
            signInManager.Setup(s => s.IsSignedIn(It.IsAny<ClaimsPrincipal>()))
                .Returns(true);

            var accountController = new AccountController(userManager.Object, signInManager.Object);

            var result = accountController.Register() as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.That(result.ControllerName == "Dashboard");
            Assert.That(result.ActionName == "Index");
        }

        [Test]
        public async Task Shows_Validation_Error_When_Passwords_Wont_Be_The_Same_HttpPost_RegisterAsyncTest()
        {
            var user = new RegisterVM()
            {
                UserName = "John",
                Email = "John@John.pl",
                Password = "12345",
                ConfirmPassowrd = "123",
                Gender = Gender.Male,
                Name = "Johny",
                Surname = "Nicolson",
                Address = "Jasnogórska 5",
                City = "Kraków",
                PostalCode = "32-143",
                PhoneNumber = "123456789"
            };


            string comparePassowordErrMessage = ((CompareAttribute)(new RegisterVM())
                .GetType()
                .GetProperty("ConfirmPassowrd")
                .GetCustomAttributes(typeof(CompareAttribute), true)[0]).ErrorMessage;

            var accountController = new AccountController(userManager.Object, signInManager.Object);

            accountController.ModelState.AddModelError("Description", comparePassowordErrMessage);

            var result = await accountController.RegisterAsync(user) as ViewResult;

            Assert.IsNotNull(result);
            Assert.That(accountController.ModelState.ErrorCount == 1);
            Assert.AreEqual(accountController.ModelState["Description"].Errors[0].ErrorMessage, comparePassowordErrMessage);
            Assert.That(result.Model == user);
        }

        [Test]
        public async Task Shows_Errors_And_Returns_Account_Register_Page_When_UserManager_Will_Return_Errors_HttpPost_RegisterAsyncTest()
        {
            var user = new RegisterVM()
            {
                UserName = "John",
                Email = "John@John.pl",
                Password = "12345",
                ConfirmPassowrd = "123",
                Gender = Gender.Male,
                Name = "Johny",
                Surname = "Nicolson",
                Address = "Jasnogórska 5",
                City = "Kraków",
                PostalCode = "32-143",
                PhoneNumber = "123456789"
            };

            userManager.Setup(s => s.CreateAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Failed(new IdentityError { Description = "Some error" }));

            var accountController = new AccountController(userManager.Object, signInManager.Object);

            var result = await accountController.RegisterAsync(user) as ViewResult;

            Assert.IsNotNull(result);
            Assert.That(accountController.ModelState.ErrorCount == 1);
            Assert.AreEqual(accountController.ModelState["RegisterUserError"].Errors[0].ErrorMessage, "Some error");
            Assert.That(result.Model == user);
        }

        [Test]
        public async Task Redirect_To_Dashboard_Index_When_Register_Succedded_HttpPost_RegisterAsyncTest()
        {
            var user = new RegisterVM()
            {
                UserName = "John",
                Email = "John@John.pl",
                Password = "12345",
                ConfirmPassowrd = "12345",
                Gender = Gender.Male,
                Name = "Johny",
                Surname = "Nicolson",
                Address = "Jasnogórska 5",
                City = "Kraków",
                PostalCode = "32-143",
                PhoneNumber = "123456789"
            };

            var accountController = new AccountController(userManager.Object, signInManager.Object);

            var result = await accountController.RegisterAsync(user) as RedirectToActionResult;

            Assert.IsNotNull(result);
            Assert.That(result.ActionName == "Index");
            Assert.That(result.ControllerName == "Dashboard");
        }
    }
    #endregion
}
