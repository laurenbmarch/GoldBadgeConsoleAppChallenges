using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ChallengeOne_Repository
{
    public enum Ingredient
    {

    }
    public class MenuItem
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<Ingredient> ListOfIngredientsInMeal { get; set; } = new List<Ingredient>();

        public MenuItem() { }
        public MenuItem(int mealNumber, string mealName, decimal price, string description, List<Ingredient> listOfIngredients)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Price = price;
            Description = description;
            ListOfIngredientsInMeal = listOfIngredients;
        }
        
    }
}
