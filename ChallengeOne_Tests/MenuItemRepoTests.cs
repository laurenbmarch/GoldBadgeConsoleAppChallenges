using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1ChallengeOne_Repo;
using System.Collections.Generic;

namespace ChallengeOne_Tests
{
    [TestClass]
    public class MenuItemRepoTests
    {

        private readonly MenuItemRepo _repo = new MenuItemRepo();
        [TestInitialize]
        public void Arrange()
        {
            MenuItem meal = new MenuItem("Chicken Sandwich", 5.99m, "Our chicken sandwich is full of flavor and can be grilled or fried.", new List<string>() { "potatoes", "bacon", "chives" });
            _repo.AddMenuItemToList(meal);
        }
        [TestMethod]
        public void Add_MealIsNull_ReturnFalse()
        {
            //Arrange
            MenuItem menuItem = null;
            MenuItemRepo menuRepo = new MenuItemRepo();

            //Act
            bool result = menuRepo.AddMenuItemToList(menuItem);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Add_MealIsNotNull_ReturnTrue()
        {
            //Arrange
            MenuItem menuItem = new MenuItem("Rueben", 6.99m, "Our Rueben is made with the freshest ingredients.", new List<string>() { "rye bread", "corned beef", "sauerkraut", "thousand island dressing" });
            MenuItemRepo menuRepo = new MenuItemRepo();

            //Act
            bool result = menuRepo.AddMenuItemToList(menuItem);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Remove_Meal()
        {

        }
    }
}
