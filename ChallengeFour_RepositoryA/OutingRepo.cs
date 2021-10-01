using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeFour_RepositoryA
{
    class OutingRepo
    {
        private List<Outing> _listOfOutings = new List<Outing>();
        
        //Display List of All Outings
        public List<Outing> DisplayAllOutings()
        {
            return _listOfOutings;
        }
        //Add Outing to List
        public void AddOutingToList(Outing newOuting)
        {
            _listOfOutings.Add(newOuting);
        }
        //View Combined Costs of All Outings
        //public decimal AddAllOutingCosts()
        //{
        //    foreach(Outing outing in _listOfOutings)
        //    {
        //        decimal totalCostOfEvent = outing.TotalCostForEvent;
                
        //    }
        //}
        //View Costs of Outings By Type
        //public decimal AddCostsByType(EventType typeOfEvent)
        //{
        //    Outing outingByType = GetOutingByType(typeOfEvent);
            
        //}
        //Helper Method
        public Outing GetOutingByType(EventType typeOfEvent)
        {
            foreach(Outing outing in _listOfOutings)
            {
                if (outing.TypeOfEvent == typeOfEvent)
                {
                    return outing;
                }
            }
            return null;
        }
    }
}
