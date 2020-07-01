using eGaraz;
using eGaraz.Enums;
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
    public class FiremenServiceTests
    {

        private DbContextOptions<AppDbContext> options;

        private Mock<FakeUserManager> userManager = new Mock<FakeUserManager>();

        private Mock<IHttpContextAccessor> httpContextAccessor = new Mock<IHttpContextAccessor>();

        [SetUp]
        public void Setup()
        {
            options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            userManager.Setup(s => s.FindByNameAsync(It.IsAny<string>()))
                .ReturnsAsync(new ApplicationUser
                {
                    UserName = "Frank",
                });

            httpContextAccessor.Setup(s => s.HttpContext.User.Identity.Name).Returns("Frank");
        }

        #region CreateFiremenAsync
        [Test]
        public async Task CreateFiremenAsyncTest()
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
                var firemenService = new FiremenService(context, userManager.Object, httpContextAccessor.Object);

                var result = await firemenService.CreateFiremenAsync(firemen);

                //Assert
                Assert.IsNotNull(result);
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
        public void Throws_If_Firemen_Entity_Will_Be_Null_CreateFiremenAsync()
        {
            using (var context = new AppDbContext(options))
            {
                var firemenService = new FiremenService(context, userManager.Object, httpContextAccessor.Object);

                Assert.ThrowsAsync<ArgumentNullException>(async () => await firemenService.CreateFiremenAsync(null));
            }
        }
        #endregion

        #region UpdateFiremenAsync
        [Test]
        public async Task UpdateFiremenAsyncTest()
        {
            var firemen = new Firemen
            {
                Id = 2,
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

            var editedFiremen = new Firemen
            {
                Id = 2,
                Name = "Justyna",
                Surname = "Wierna",
                Birthdate = DateTime.Today,
                City = "Katowice",
                DigitalCode = "32-065",
                Son_Daughter = "Marka",
                Street = "BakerStreet",
                Pesel = "56482548796",
                Management = false,
                HouseNumber = "221B",
                Gender = Gender.Female,
                Active = false,
                Function = "Stra¿ak-Ratownik",
                FlatNumber = 6,
                ApplicationUser = new ApplicationUser { }
            };

            using (var context = new AppDbContext(options))
            {
                var firemenService = new FiremenService(context, userManager.Object, httpContextAccessor.Object);

                await firemenService.CreateFiremenAsync(firemen);

                context.Entry(firemen).State = EntityState.Detached;

                var result = await firemenService.UpdateFiremenAsync(editedFiremen);

                var foundFiremen = await context.Firemens.FindAsync(2);

                Assert.IsNotNull(result);
                Assert.That(foundFiremen.Name == "Justyna");
                Assert.That(foundFiremen.Surname == "Wierna");
                Assert.That(foundFiremen.Birthdate.Equals(DateTime.Today));
                Assert.That(foundFiremen.City == "Katowice");
                Assert.That(foundFiremen.DigitalCode == "32-065");
                Assert.That(foundFiremen.Street == "BakerStreet");
                Assert.That(foundFiremen.Pesel == "56482548796");
                Assert.That(foundFiremen.Son_Daughter == "Marka");
                Assert.That(!foundFiremen.Management);
                Assert.That(foundFiremen.HouseNumber == "221B");
                Assert.That(foundFiremen.Gender == Gender.Female);
                Assert.That(!foundFiremen.Active);
                Assert.That(foundFiremen.Function == "Stra¿ak-Ratownik");
                Assert.That(foundFiremen.FlatNumber == 6);
                Assert.IsNotNull(foundFiremen.UpdatedAt);
                Assert.IsNotNull(foundFiremen.UpdatedBy);
            }
        }

        [Test]
        public void Throws_If_Firemen_Entity_Will_Be_Null_UpdateFiremenAsync()
        {
            using (var context = new AppDbContext(options))
            {
                var firemenService = new FiremenService(context, userManager.Object, httpContextAccessor.Object);

                Assert.ThrowsAsync<ArgumentNullException>(async () => await firemenService.UpdateFiremenAsync(null));
            }
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void Throws_If_Firemen_ID_Wont_Be_Greater_Than_Zero_UpdateFiremenAsync(int id)
        {
            var firemen = new Firemen
            {
                Id = id,
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
                var firemenService = new FiremenService(context, userManager.Object, httpContextAccessor.Object);

                Assert.ThrowsAsync<ArgumentException>(async () => await firemenService.UpdateFiremenAsync(firemen));
            }
        }

        [Test]
        public void Throws_If_Firemen_Was_Not_Found_UpdateFiremenAsync()
        {
            var firemen = new Firemen
            {
                Id = 5,
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
                var firemenService = new FiremenService(context, userManager.Object, httpContextAccessor.Object);

                Assert.ThrowsAsync<Exception>(async () => await firemenService.UpdateFiremenAsync(firemen));
            }
        }

        [Test]
        public async Task Throws_If_Firemen_Deleted_Property_Will_Be_True_UpdateFiremenAsync()
        {
            var firemen = new Firemen
            {
                Id = 3,
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
                Deleted = true
            };

            using (var context = new AppDbContext(options))
            {
                var firemenService = new FiremenService(context, userManager.Object, httpContextAccessor.Object);

                await firemenService.CreateFiremenAsync(firemen);

                Assert.ThrowsAsync<Exception>(async () => await firemenService.UpdateFiremenAsync(firemen));
            }
        }
        #endregion

        #region DeleteFiremenAsync

        [TestCase(0)]
        [TestCase(-5)]
        public void Throws_If_ID_Wont_Be_Greather_Than_Zero_DeleteFiremenAsync(int id)
        {
            using (var context = new AppDbContext(options))
            {
                var firemenService = new FiremenService(context, userManager.Object, httpContextAccessor.Object);

                Assert.ThrowsAsync<ArgumentException>(async () => await firemenService.DeleteFiremenAsync(id));
            }
        }

        [Test]
        public void Throws_If_Firemen_Was_Not_Found_DeleteFiremenAsync()
        {
            using (var context = new AppDbContext(options))
            {
                var firemenService = new FiremenService(context, userManager.Object, httpContextAccessor.Object);

                Assert.ThrowsAsync<Exception>(async () => await firemenService.DeleteFiremenAsync(10));
            }
        }

        [Test]
        public async Task Throws_If_Firemen_Deleted_Property_Will_Be_True_DeleteFiremenAsync()
        {
            var firemen = new Firemen
            {
                Id = 7,
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
                Deleted = true
            };

            using (var context = new AppDbContext(options))
            {
                var firemenService = new FiremenService(context, userManager.Object, httpContextAccessor.Object);

                await firemenService.CreateFiremenAsync(firemen);

                Assert.ThrowsAsync<Exception>(async () => await firemenService.DeleteFiremenAsync(7));
            }
        }

        [Test]
        public async Task DeleteFiremenAsyncTest()
        {
            var firemen = new Firemen
            {
                Id = 4,
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
                var firemenService = new FiremenService(context, userManager.Object, httpContextAccessor.Object);

                await firemenService.CreateFiremenAsync(firemen);

                await firemenService.DeleteFiremenAsync(4);

                var foundFiremen = await context.Firemens.FindAsync(4);

                Assert.IsTrue(foundFiremen.Deleted);
                Assert.IsNotNull(foundFiremen.DeletedAt);
                Assert.IsNotNull(foundFiremen.DeletedBy);
            }
        }
        #endregion

        #region GetFiremenByIdAsync

        [TestCase(0)]
        [TestCase(-10)]
        public void Throws_If_ID_Wont_Be_Greather_Than_Zero_GetFiremenByIdAsyncId(int id)
        {
            using (var context = new AppDbContext(options))
            {
                var firemenService = new FiremenService(context, userManager.Object, httpContextAccessor.Object);

                Assert.ThrowsAsync<ArgumentException>(async () => await firemenService.GetFiremenByIdAsync(id));
            }
        }

        [Test]
        public void Throws_If_Firemen_Was_Not_Found_GetFiremenByIdAsyncId()
        {
            using (var context = new AppDbContext(options))
            {
                var firemenService = new FiremenService(context, userManager.Object, httpContextAccessor.Object);

                Assert.ThrowsAsync<Exception>(async () => await firemenService.GetFiremenByIdAsync(20));
            }
        }

        [Test]
        public async Task GetFiremenByIdAsyncTest()
        {
            var firemen = new Firemen
            {
                Id = 11,
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
                var firemenService = new FiremenService(context, userManager.Object, httpContextAccessor.Object);

                await firemenService.CreateFiremenAsync(firemen);

                var result = await firemenService.GetFiremenByIdAsync(11);

                Assert.IsNotNull(result);
                Assert.IsNotNull(result.Firemen);
            }
        }
        #endregion

        #region GetAllFiremensAsync
        [TestCase(EntityStatus.Existing)]
        [TestCase(EntityStatus.Deleted)]
        [TestCase(EntityStatus.All)]
        public async Task GetAllFiremensAsync(EntityStatus entityStatus)
        {
            using (var context = new AppDbContext(options))
            {
                await context.Firemens.ForEachAsync(f => context.Firemens.Remove(f));

                var firemenService = new FiremenService(context, userManager.Object, httpContextAccessor.Object);

                for (int i = 1; i < 7; i++)
                {
                    var firemen = new Firemen
                    {
                        Id = i,
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
                        Deleted = i % 2 == 0 ? true : default(bool)
                    };

                    await firemenService.CreateFiremenAsync(firemen);
                }

                var result = await firemenService.GetAllFiremensAsync(entityStatus);

                if (entityStatus == EntityStatus.Existing)
                {
                    Assert.IsNotNull(result);
                    Assert.That(result.Count() == 3);
                    Assert.That(result.All(a => a.Firemen != null));
                }
                else if (entityStatus == EntityStatus.Deleted)
                {
                    Assert.IsNotNull(result);
                    Assert.That(result.Count() == 3);
                    Assert.That(result.All(a => a.Firemen != null));
                }
                else if (entityStatus == EntityStatus.All)
                {
                    Assert.IsNotNull(result);
                    Assert.That(result.Count() == 6);
                    Assert.That(result.All(a => a.Firemen != null));
                }
            }
        }
        #endregion
    }
}