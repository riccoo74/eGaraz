using eGaraz;
using eGaraz.Models;
using eGaraz.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eGarazTests
{
    [TestFixture]
    public class Tests
    {

        private DbContextOptions<AppDbContext> options;

        private Mock<UserManager<ApplicationUser>> mockUser =
            new Mock<UserManager<ApplicationUser>>(new Mock<IUserStore<ApplicationUser>>().Object, null, null, null, null, null, null, null, null);

        private Mock<IHttpContextAccessor> mockAccessor = new Mock<IHttpContextAccessor>();

        [SetUp]
        public void Setup()
        {
            options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "eGaraz")
                .Options;

            mockUser.Setup(s => s.FindByNameAsync(It.IsAny<string>()))
                .ReturnsAsync(new ApplicationUser
                {
                    UserName = "Frank",
                });

            mockAccessor.Setup(s => s.HttpContext.User.Identity.Name).Returns("Frank");
        }

        [Test]
        public async Task CreateAsyncFiremenTest()
        {
            //Arrange
            var firemen = new Firemen
            {
                Name = "Jan",
                Surname = "Kowalski",
                Birthdate = DateTime.Today,
                City = "Kraków",
                DigitalCode = "31-231",
                Son_Daughter = "Stefana",
                Street = "Jasnogórska",
                Pesel = "87542165874",
                Management = true,
                HouseNumber = "146B",
                Gender = Gender.Male,
                Active = true,
                Function = "Kierowca",
                FlatNumber = 5,
            };

            using (var context = new AppDbContext(options))
            {
                //Act
                var firemenService = new FiremenService(context, mockUser.Object, mockAccessor.Object);

                var result = await firemenService.CreateFiremenAsync(firemen);

                //Assert
                Assert.IsTrue(result.Succedeed);
                Assert.That(context.Firemens.Count() == 1);
                Assert.That(context.Firemens.First().Name == "Jan");
                Assert.That(context.Firemens.First().Surname == "Kowalski");
                Assert.That(context.Firemens.First().Birthdate.Equals(DateTime.Today));
                Assert.That(context.Firemens.First().City == "Kraków");
                Assert.That(context.Firemens.First().DigitalCode == "31-231");
                Assert.That(context.Firemens.First().Street == "Jasnogórska");
                Assert.That(context.Firemens.First().Pesel == "87542165874");
                Assert.That(context.Firemens.First().Management);
                Assert.That(context.Firemens.First().HouseNumber == "146B");
                Assert.That(context.Firemens.First().Gender == Gender.Male);
                Assert.That(context.Firemens.First().Active);
                Assert.That(context.Firemens.First().Function == "Kierowca");
                Assert.That(context.Firemens.First().FlatNumber == 5);
                Assert.IsNotNull(context.Firemens.First().CreatedAt);
                Assert.IsNotNull(context.Firemens.First().CreatedBy);
            }
        }

        [Test]
        public void Throws_If_Firemen_Entity_Will_Be_Null()
        {
            using (var context = new AppDbContext(options))
            {
                var firemenService = new FiremenService(context, mockUser.Object, mockAccessor.Object);

                Assert.ThrowsAsync<ArgumentNullException>(async () => await firemenService.CreateFiremenAsync(null));
            }
        }
    }
}