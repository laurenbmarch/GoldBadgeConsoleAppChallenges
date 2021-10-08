using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ChallengeThree_Repository
{
    public class BadgeRepo
    {
        private Dictionary<int, Badge> _dictionaryOfBadges = new Dictionary<int, Badge>();

         
        //Create a Badge
        public bool AddBadgeToDictionary(int badgeID, Badge badge)
        {
            if(badge == null)
            {
                return false;
            }
            _dictionaryOfBadges.Add(badgeID, badge);
            return true;
        }

        //Update a Badge
        public bool UpdateDoors (int badgeID, Badge newBadge, int addOrRemove)
        {
            //Find the Badge By it's ID Number
            var existingBadge = GetBadgeByIDNumber(badgeID);

            //Update the badge
            if(existingBadge != null)
            {
                existingBadge.ListOfDoorNames = newBadge.ListOfDoorNames;
                existingBadge.BadgeName = newBadge.BadgeName;
                return true;
            }
            else
            {
                return false;
            }

        }

        //Get Badge By ID Number
        public Badge GetBadgeByIDNumber(int badgeIDNumber)
        {
            if( _dictionaryOfBadges.ContainsKey(badgeIDNumber))
            {
                Badge badge = _dictionaryOfBadges[badgeIDNumber];
                return badge;
            }
            return null;
        }
        //Get all Badge numbers and cooresponding door access
        public Dictionary<int, Badge> GetListOfAllBadges()
        {
            var DictionaryOfBadges = new Dictionary<int, Badge>();
            return DictionaryOfBadges;

        }

    }
}
