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
                Console.WriteLine("Welcome Komodo Insurance Admin!");
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
        //Update Doors on a Badge
        private void EditABadge()
        {
            Console.Clear();
            Console.WriteLine("Please enter the ID Number of the badge you would like to update: ");
            int idNumber;
    
                idNumber = int.Parse(Console.ReadLine());
                Badge badge = _badgeRepo.GetBadgeByIDNumber(idNumber);

                if (badge != null)
                {
                    Console.WriteLine($"Badge Number {idNumber} has access to doors {string.Join(",",badge.ListOfDoorNames)}\n");
                    Console.WriteLine("What would you like to do? (enter 1 or 2)\n" +
                        "1. Add access to a door\n" +
                        "2. Remove access to a door");
                    try
                    {
                        int userChoice = int.Parse(Console.ReadLine());
                        switch (userChoice)
                        {
                            case 1:
                                bool userIsNotFinishedUpdating = true;
                                while (userIsNotFinishedUpdating)
                                {
                                    Console.WriteLine("Please enter the door you would like to add: ");
                                    string newDoorName = Console.ReadLine();
                                    badge.ListOfDoorNames.Add(newDoorName);
                                    Console.WriteLine("Would you like to add another door? (yes/no)");
                                    try
                                    {
                                        string wantsToAddAnotherDoor = Console.ReadLine();
                                        if (wantsToAddAnotherDoor == "no")
                                        {
                                            userIsNotFinishedUpdating = false;
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Invalid Selection.");
                                    }
                                }
                                break;
                            case 2:
                                bool userIsNotFinishedRemovingDoors = true;
                                while (userIsNotFinishedRemovingDoors)
                                {
                                    Console.WriteLine("Please enter the door you would like to remove:");
                                    string doorToRemove = Console.ReadLine();
                                    badge.ListOfDoorNames.Remove(doorToRemove);
                                    Console.WriteLine("Would you like to remove any other doors? (yes/no)");
                                    try
                                    {
                                        string wantsToRemoveAnotherDoor = Console.ReadLine();
                                        if (wantsToRemoveAnotherDoor == "no")
                                        {
                                            userIsNotFinishedRemovingDoors = false;
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Invalid Selection.");
                                    }
                                }
                                break;
                                default:
                                Console.WriteLine("Please enter a valid selection.");
                                break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Selection.");
                    }
                }
            else
            {
                Console.WriteLine("Could not update that Badge.");
            } 
        }
        //Display Dictionary of Badges
        private void ListAllBadges()
        {
            Console.Clear();
            Dictionary<int, Badge> dictionaryOfBadgeElements= _badgeRepo.GetListOfAllBadges();
            Console.WriteLine("\nHere is a list of all badges in use and their cooresponding doors of access:\n");
            foreach(KeyValuePair<int, Badge> badgeElement in dictionaryOfBadgeElements)
            {
                Console.WriteLine($"\tBadge ID: {badgeElement.Key}\n \tDoor Access: {string.Join(",", badgeElement.Value.ListOfDoorNames)}");
            }
        }
        //Seed Data
        private void SeedData()
        {
            Badge exampleBadgeOne = new Badge(1234, "Lauren March", new List<string>() { "A1", "A3", "B7" });
            Badge exampleBadgeTwo = new Badge(2244, "James March", new List<string>() { "D3", "D4", "D5" });
            Badge exampleBadgeThree = new Badge(1021, "Henry March", new List<string>() { "A1", "B2", "C3" });
            _badgeRepo.AddBadgeToDictionary(exampleBadgeOne.BadgeID, exampleBadgeOne);
            _badgeRepo.AddBadgeToDictionary(exampleBadgeTwo.BadgeID, exampleBadgeTwo);
            _badgeRepo.AddBadgeToDictionary(exampleBadgeThree.BadgeID, exampleBadgeThree);
        }
    }
}
