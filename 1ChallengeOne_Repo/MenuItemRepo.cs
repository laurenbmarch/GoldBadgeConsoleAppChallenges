using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ChallengeOne_Repo
{
    public class MenuItemRepo
    {
        private List<MenuItem> _listOfMenuItems = new List<MenuItem>();
        private int _countForMealNumber = 0;
        //Create
        public void AddMenuItemToList(MenuItem menuItem)
        {
            menuItem.MealNumber = ++_countForMealNumber;
            _listOfMenuItems.Add(menuItem);
        }
        //Read
        public List<MenuItem> GetMenuList()
        {
            return _listOfMenuItems;
        }
        //Delete
        public bool RemoveItemFromMenu(string itemName)
        {
            MenuItem menuItem = GetMenuItemByName(itemName);
            if (menuItem == null)
            {
                return false;
            }
            int initialCount = _listOfMenuItems.Count;
            _listOfMenuItems.Remove(menuItem);

            if (initialCount > _listOfMenuItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Get Menu Item By Name
        public MenuItem GetMenuItemByName(string name)
        {
            foreach (MenuItem item in _listOfMenuItems)
            {
                if (item.MealName.ToLower() == name.ToLower())
                {
                    return item;
                }
            }
            return null;
        }
    }
}
