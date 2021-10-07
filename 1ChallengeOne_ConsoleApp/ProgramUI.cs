using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1ChallengeOne_Repo;

namespace _1ChallengeOne_ConsoleApp
{
    public class ProgramUI
    {
        private MenuItemRepo _menuRepo = new MenuItemRepo();
        public void Run()
        {
            SeedMenuItems();
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select an option: \n" +
                    "\t1. View All Menu Items \n" +
                    "\t2. Create a New Menu Item \n" +
                    "\t3. Delete a Menu Item \n" +
                    "\t4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DisplayAllMenuItems();
                        break;
                    case "2":
                        CreateNewMenuItem();
                        break;
                    case "3":
                        DeleteExistingMenuItem();
                        break;
                    case "4":
                        Console.WriteLine("Exiting Now");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number (1, 2, 3, or 4)");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //Display List of Menu Items
        private void DisplayAllMenuItems()
        {
            Console.Clear();
            List<MenuItem> listOfMenuItems = _menuRepo.GetMenuList();
            foreach (MenuItem menuItem in listOfMenuItems)
            {
                Console.WriteLine($"Meal Number: {menuItem.MealNumber}\n" +
                    $"Meal Name: {menuItem.MealName}\n" +
                    $"Price: {menuItem.Price}\n" +
                    $"Description: {menuItem.Description}\n" +
                    $"Ingredients: {string.Join(",", menuItem.ListOfIngredientsInMeal)}\n\n");
            }

        }
       
        //Create New Menu Item
        private void CreateNewMenuItem()
        {
            Console.Clear();
            MenuItem newMenuItem = new MenuItem();
            //Meal Name
            Console.WriteLine("Enter the name of the meal you would like to add:");
            try
            {
                newMenuItem.MealName = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Invalid entry.");
            }
            
            //Meal Price
            Console.WriteLine("Enter the price of the meal:");
            try
            {
                newMenuItem.Price = decimal.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid entry.");
            }

            //Meal Description
            Console.WriteLine("Enter a description of the meal:");
            try
            {
                newMenuItem.Description = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Invalid entry.");
            }
            
            //Meal Ingredient List
            Console.WriteLine("Enter the ingredients of the meal:");
            try
            {
                string newIngredients = Console.ReadLine();
                newMenuItem.ListOfIngredientsInMeal.Add(newIngredients);
            }
            catch
            {
                Console.WriteLine("Invalid entry.");
            }

            _menuRepo.AddMenuItemToList(newMenuItem);
        }

        //Delete Menu Item
        private void DeleteExistingMenuItem()
        {
            DisplayAllMenuItems();
            Console.WriteLine("\n Enter the name of the meal that you want to remove: ");
            string mealToRemove;

            mealToRemove = Console.ReadLine();
            bool wasDeleted = _menuRepo.RemoveItemFromMenu(mealToRemove);

            if (wasDeleted)
            {
                Console.WriteLine("The menu item was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The menu item could not be deleted.");
            }
        }

        //Seed Content
        private void SeedMenuItems()
        {
            MenuItem exampleMealOne = new MenuItem("Chopped Salad", 5.99m, "Our chopped salad is prepared fresh daily with locally grown ingredients.", new List<string>(){ "spinach", "romaine lettuce", "chicken", "tomatoes", "avocado", "cucumber"});
            MenuItem exampleMealTwo = new MenuItem("BLT", 4.99m, "Our BLT is full of flavor with a big crunch!", new List<string>(){"whole wheat bread", "bacon", "lettuce", "tomato"});
            MenuItem exampleMealThree = new MenuItem("Potato Soup", 3.99m, "Comfort food in a bowl!", new List<string>(){ "potatoes", "bacon", "chives" });
            _menuRepo.AddMenuItemToList(exampleMealOne);
            _menuRepo.AddMenuItemToList(exampleMealTwo);
            _menuRepo.AddMenuItemToList(exampleMealThree);
        }
    }
}
