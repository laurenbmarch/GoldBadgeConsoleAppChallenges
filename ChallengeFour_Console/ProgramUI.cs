using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeFour_RepositoryA;


namespace ChallengeFour_Console
{
    public class ProgramUI
    {
        private OutingRepo _outingRepo = new OutingRepo();
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
                    "\t1. View All Outings \n" +
                    "\t2. Add A New Outing \n" +
                    "\t3. Display Combined Costs for All Outings \n" +
                    "\t4. Display Costs by Type of Event\n" +
                    "\t5. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DisplayAllOutings();
                        break;
                    case "2":
                        CreateNewOuting();
                        break;
                    case "3":
                        DisplayTotalCombinedCosts();
                        break;
                    case "4":
                        DisplayCostsByType();
                        break;
                    case "5":
                        Console.WriteLine("Exiting Now");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number (1, 2, 3, 4, or 5)");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        //Display List of All Outings
        private void DisplayAllOutings()
        {
            Console.Clear();
            List<Outing> listOfOutings = _outingRepo.GetAllOutings();
            foreach (Outing outing in listOfOutings)
            {
                Console.WriteLine($"Date: {outing.DateOfEvent.Date}\n" +
                    $"Event Type: {outing.TypeOfEvent}\n" +
                    $"Number of Attendees: {outing.NumberOfAttendees}\n" +
                    $"Cost Per Person: {outing.CostPerPerson}\n" +
                    $"Total Cost for the Event: {outing.TotalCostForEvent}\n\n");
            }

        }
        //Create New Outing
        private void CreateNewOuting()
        {
            Console.Clear();
            Outing outing = new Outing();
            
            //Date of Outing
            Console.WriteLine("Enter the date of the outing (ex: 11/23/2020): ");
            outing.DateOfEvent = DateTime.Parse(Console.ReadLine());
            
            //Type of Event
            Console.WriteLine("What was the type of event? (Enter 1, 2, 3, or 4): \n" +
                "1. Golf \n" +
                "2. Bowling \n" +
                "3. Amusement Park \n" +
                "4. Concert");
            int eventChoice = int.Parse(Console.ReadLine());
            outing.TypeOfEvent = (EventType)eventChoice;

            //Number of Attendees
            Console.WriteLine("Enter the total number of attendees: ");
            outing.NumberOfAttendees = int.Parse(Console.ReadLine());

            //Cost per person
            Console.WriteLine("Enter the cost per person (ex: 14.99)");
            outing.CostPerPerson = decimal.Parse(Console.ReadLine());

            //Total Cost
            Console.WriteLine("Enter the total cost of the event (ex: 499.99)");
            outing.TotalCostForEvent = decimal.Parse(Console.ReadLine());

            _outingRepo.AddOutingToList(outing);
        }
        //Display Total Combined Costs
        private void DisplayTotalCombinedCosts()
        {
            Console.Clear();
            decimal totalCost =_outingRepo.AddAllOutingCosts();
            Console.WriteLine($"Here is the total combined costs of all outings:{totalCost}\n\n");

            //Console.WriteLine("Would you like to view the combined costs by year? (yes/no):");
        }
        //Display Costs By Type
        private void DisplayCostsByType()
        {
            Console.Clear();
            Console.WriteLine("Which type of event would you like to see total costs:\n" +
                "1. Golf \n" +
                "2. Bowling \n" +
                "3. Amusement Park \n" +
                "4. Concert");
            int eventChoice = int.Parse(Console.ReadLine());
            EventType typeOfEvent = (EventType)eventChoice;
            decimal totalCostOfEventType = _outingRepo.AddCostsByType(typeOfEvent);
            Console.WriteLine($"The total cost of {typeOfEvent} events is:{totalCostOfEventType}");

        }
        //Seed Data
        private void SeedMenuItems()
        {
            Outing outingExampleOne = new Outing(EventType.Golf, 30, new DateTime(2021, 5, 16), 59.99m, 1799.70m);
            Outing outingExampleTwo = new Outing(EventType.Bowling, 40, new DateTime(2021, 10, 1), 25.99m, 1039.60m);

            _outingRepo.AddOutingToList(outingExampleOne);
            _outingRepo.AddOutingToList(outingExampleTwo);
        }
    }
}
