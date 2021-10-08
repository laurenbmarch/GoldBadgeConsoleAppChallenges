using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1ChallengeOne_Repo;
using System.Collections.Generic;

namespace ChallengeOne_Tests
{
    [TestClass]
    public class MenuItemRepoTests
    {
        private readonly MenuItemRepo _repo = new MenuItemRepo();
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
        public void GetMenuItemByName_MealDoesNotExist_ReturnNull()
        {
            //Arrange
            MenuItem meal = new MenuItem("Avocado Toast", 3.99m, "Simple, yet protein-packed and delicious.", new List<string>() { "whole wheat toast", "avocado", "sea salt" });
            MenuItemRepo repository = new MenuItemRepo();
            repository.AddMenuItemToList(meal);

            //Act
            MenuItem result = repository.GetMenuItemByName("Toast");

            //Assert
            Assert.IsNull(result);
        }
        [TestMethod]
        public void GetMenuItemByName_MealDoesExist_ReturnIsNotNull()
        {
            //Arrange
            MenuItem meal = new MenuItem("Avocado Toast", 3.99m, "Simple, yet protein-packed and delicious.", new List<string>() { "whole wheat toast", "avocado", "sea salt" });
            MenuItemRepo repository = new MenuItemRepo();
            repository.AddMenuItemToList(meal);

            //Act
            MenuItem result = repository.GetMenuItemByName("Avocado Toast");

            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void DeleteMeal_MealDoesNotExist_ReturnFalse()
        {
            //Arrange
            MenuItem meal = new MenuItem("Avocado Toast", 3.99m, "Simple, yet protein-packed and delicious.", new List<string>() { "whole wheat toast", "avocado", "sea salt" });
            MenuItemRepo repository = new MenuItemRepo();
            repository.AddMenuItemToList(meal);

            //Act
            bool result = repository.RemoveItemFromMenu("Toast");

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void DeleteMeal_MealDoesExist_ReturnTrue()
        {
            //Arrange
            MenuItem meal = new MenuItem("Avocado Toast", 3.99m, "Simple, yet protein-packed and delicious.", new List<string>() { "whole wheat toast", "avocado", "sea salt" });
            MenuItemRepo repository = new MenuItemRepo();
            repository.AddMenuItemToList(meal);

            //Act
            bool result = repository.RemoveItemFromMenu("Avocado Toast");

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GetMenuList_ListDoesExist_ReturnIsNotNull()
        {
            //Arrange
            MenuItemRepo repository = new MenuItemRepo();

            //Assert
            Assert.IsNotNull(repository.GetMenuList());
        }
    }
}
