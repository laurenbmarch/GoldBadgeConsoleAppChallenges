using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3ChallengeThree_Repository;

namespace Challenge3_Console
{
    public class ProgramUI
    {
        private BadgeRepo _badgeRepo = new BadgeRepo();
        //private Dictionary<int, Badge> _dictionaryOfBadges;

        public void Run()
        {
            SeedData();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while(keepRunning)
            {
                Console.WriteLine("Select a menu option:\n" +
                    "\t1. Add a Badge\n" +
                    "\t2. Edit a Badge\n" +
                    "\t3. List all Badges\n" +
                    "\t4. Exit");

                string userInput = Console.ReadLine();

                switch(userInput)
                {
                    case "1":
                        //Create New Badge
                        AddABadge();
                        break;
                    case "2":
                        //Update Doors on Existing Badge
                        EditABadge();
                        break;
                    case "3":
                        //Display Dictionary of Badges
                        ListAllBadges();
                        break;
                    case "4":
                        //Exit
                        Console.WriteLine("Exiting Now.");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //Create New Badge
        private void AddABadge()
        {
            Console.Clear();
            Badge newBadge = new Badge();

            //Assigning Badge ID
            Console.WriteLine("Please enter the badge number: ");
            try
            {
                newBadge.BadgeID = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid entry.");
            }

            //Assigning List of Door Access
            Console.WriteLine("Please enter the doors this badge needs access to: ");
            try
            {
                string doorNames = Console.ReadLine();
                newBadge.ListOfDoorNames.Add(doorNames);
            }
            catch
            {
                Console.WriteLine("Invalid entry.");
            }

            //Add it to the Dictionary
            bool wasAdded = _badgeRepo.AddBadgeToDictionary(newBadge.BadgeID, newBadge);
            if (wasAdded)
            {
                Console.WriteLine("The badge was successfully added to the sytem.");
            }
            else
            {
                Console.WriteLine("The badge could not be added to the system.");
            }
        }
    }
}
