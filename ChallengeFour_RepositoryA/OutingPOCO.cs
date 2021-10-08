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
        public DateTime DateOfEvent { get; set; } = new DateTime();
        public decimal CostPerPerson { get; set; }
        public decimal TotalCostForEvent { get; set; }
        public Outing() { }
        public Outing (EventType typeOfEvent, int numOfAttendees, DateTime eventDate, decimal costPerPerson, decimal totalCostForEvent)
        {
            TypeOfEvent = typeOfEvent;
            NumberOfAttendees = numOfAttendees;
            DateOfEvent = eventDate;
            CostPerPerson = costPerPerson;
            TotalCostForEvent = totalCostForEvent;
        }


    }
}
