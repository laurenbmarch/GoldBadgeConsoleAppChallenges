using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ChallengeOne_Repo
{
    public class MenuItem
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<string> ListOfIngredientsInMeal { get; set; } = new List<string>();
        public MenuItem() { }
        public MenuItem(string mealName, decimal price, string description, List<string> listOfIngredients)
        {
            MealName = mealName;
            Price = price;
            Description = description;
            ListOfIngredientsInMeal = listOfIngredients;
        }
    }
}
