using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeFour_RepositoryA
{
    public class OutingRepo
    {
        private List<Outing> _listOfOutings = new List<Outing>();
        
        //Display List of All Outings
        public List<Outing> GetAllOutings()
        {
            return _listOfOutings;
        }
       
        //Add Outing to List
        public bool AddOutingToList(Outing newOuting)
        {
            if (newOuting is null)
            {
                return false;
            }
            _listOfOutings.Add(newOuting);
            return true;
        }
        
        //View Combined Costs of All Outings
        public decimal AddAllOutingCosts()
        {
            decimal totalOutingCosts = _listOfOutings.Sum(outing => outing.TotalCostForEvent);
            return totalOutingCosts;
        }
        
        //View Costs of Outings By Type
        public decimal AddCostsByType(EventType typeOfEvent)
        {
            List<Outing> listByType = new List<Outing>();
            foreach (Outing outing in _listOfOutings)
            {
                if(typeOfEvent == outing.TypeOfEvent)
                {
                    listByType.Add(outing);
                }
            }

            decimal SumByEventType = listByType.Sum(outing => outing.TotalCostForEvent);
            return SumByEventType;
        }
    }
}
