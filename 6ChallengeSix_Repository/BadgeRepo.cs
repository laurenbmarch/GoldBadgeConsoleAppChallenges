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
        public void AddBadgeToDictionary(int badgeID, Badge badge)
        {
            _dictionaryOfBadges.Add(badgeID, badge);
        }

        //Update a Badge
        public void UpdateDoors (int badgeID, Badge badge, int addOrRemove)
        {
            //Find the Badge By it's ID Number
            var existingBadge = GetListOfDoorsByIDNumber(badgeID);

        }

        //Get Badge By ID Number
        public Badge GetListOfDoorsByIDNumber(int badgeIDNumber)
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
