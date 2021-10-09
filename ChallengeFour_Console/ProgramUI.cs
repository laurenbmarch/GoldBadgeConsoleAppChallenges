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
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Welcome Komodo Admin!");
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
                Console.WriteLine($"Date: {(outing.DateOfEvent).ToShortDateString()}\n" +
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

            //Set Total Cost
            outing.TotalCostForEvent = (outing.CostPerPerson) * (outing.NumberOfAttendees);

            _outingRepo.AddOutingToList(outing);
        }

        //Display Total Combined Costs
        private void DisplayTotalCombinedCosts()
        {
            Console.Clear();
            decimal totalCost =_outingRepo.AddAllOutingCosts();
            Console.WriteLine($"\nThe total combined costs of all outings is: {totalCost}");
        }

        //Display Costs By Type
        private void DisplayCostsByType()
        {
            Console.Clear();
            Console.WriteLine("Here are the total costs by Event Type:\n" +
                $"1. Golf: {_outingRepo.AddCostsByType(EventType.Golf)}\n" +
                $"2. Bowling: {_outingRepo.AddCostsByType(EventType.Bowling)}\n" +
                $"3. Amusement Park: {_outingRepo.AddCostsByType(EventType.AmusementPark)}\n" +
                $"4. Concert: {_outingRepo.AddCostsByType(EventType.Concert)}");
        }
       
        //Seed Data
        private void SeedMenuItems()
        {
            Outing outingExampleOne = new Outing(EventType.Golf, 30, new DateTime(2021, 05, 16), 50m, 1500m);
            Outing outingExampleTwo = new Outing(EventType.Bowling, 40, new DateTime(2021, 10, 1), 20.00m, 800.00m);
            Outing outingExampleThree = new Outing(EventType.AmusementPark, 10, new DateTime(2021, 03, 02), 40.00m, 400.00m);
            Outing outingExampleFour = new Outing(EventType.Concert, 30, new DateTime(2021, 08, 23), 40m, 1200m); 
            _outingRepo.AddOutingToList(outingExampleOne);
            _outingRepo.AddOutingToList(outingExampleTwo);
            _outingRepo.AddOutingToList(outingExampleThree);
            _outingRepo.AddOutingToList(outingExampleFour);
        }
    }
}
