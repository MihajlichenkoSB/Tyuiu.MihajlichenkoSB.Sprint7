using Tyuiu.MihajlichenkoSB.Sprint7.Project.V2.Lib.Models;
using Tyuiu.MihajlichenkoSB.Sprint7.Project.V2.Lib.Services;

namespace Tyuiu.MihajlichenkoSB.Sprint7.Project.V2.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void AddOwner_ValidData_OwnerAdded()
        {
            // Arrange
            var service = new DataService();
            var owner = new Owner
            {
                Id = 1,
                FullName = "Иванов И.И.",
                Capital = 1000000
            };

            // Act
            service.AddOwner(owner);
            var owners = service.GetOwners();

            // Assert
            Assert.AreEqual(1, owners.Count);
            Assert.AreEqual("Иванов И.И.", owners[0].FullName);
        }

        [TestMethod]
        public void GetTotalCapital_ThreeOwners_ReturnsSum()
        {
            // Arrange
            var service = new DataService();
            service.AddOwner(new Owner { Capital = 1000 });
            service.AddOwner(new Owner { Capital = 2000 });
            service.AddOwner(new Owner { Capital = 3000 });

            // Act
            var total = service.GetTotalCapital();

            // Assert
            Assert.AreEqual(6000, total);
        }
    }
}
