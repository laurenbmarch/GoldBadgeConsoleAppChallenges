using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _ChallengeOne_Repository;

namespace ChallengeOne_Console
{
    public class ProgramUI
    {
        private MenuItemRepository _menuRepo = new MenuItemRepository();
        public void Run()
        {
            Menu();
        }
        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while(keepRunning)
            {
                Console.WriteLine();
            }
        }
    }
}
