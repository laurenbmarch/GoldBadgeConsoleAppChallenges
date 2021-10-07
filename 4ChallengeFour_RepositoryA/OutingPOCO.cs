using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeFour_RepositoryA
{
    public enum EventType
    {
        Golf = 1,
        Bowling,
        AmusementPark,
        Concert
    }
    public class Outing
    {
        public EventType TypeOfEvent { get; set; }
        public int NumberOfAttendees { get; set; }
        public string DateOfEvent { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
        public decimal CostPerPerson { get; set; }
        public decimal TotalCostForEvent { get; set; }

        public Outing() { }
        public Outing (EventType typeOfEvent, int numOfAttendees, string eventDate, decimal costPerPerson, decimal totalCostForEvent)
        {
            TypeOfEvent = typeOfEvent;
            NumberOfAttendees = numOfAttendees;
            DateOfEvent = eventDate;
            CostPerPerson = costPerPerson;
            TotalCostForEvent = totalCostForEvent;
        }


    }
}
