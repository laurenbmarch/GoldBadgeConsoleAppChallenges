using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ChallengeThree_Repository
{
    public class BadgeRepo
    {
        private Dictionary<int, List<string>> _dictionaryOfBadges = new Dictionary<int, List<string>>();


        //Create a Badge
        public void AddBadgeToDictionary(int badgeID, List<string> doorNames)
        {
            _dictionaryOfBadges.Add(badgeID, doorNames);
        }

        //Update a Badge
        public void UpdateDoors (int badgeID, List<string> listOfDoors, int addOrRemove)
        {
            //Find the Badge By it's ID Number
            var existingBadge = GetListOfDoorsByIDNumber(badgeID);

        }

        //Get Badge By ID Number
        public List<string> GetListOfDoorsByIDNumber(int badgeIDNumber)
        {
            if( _dictionaryOfBadges.ContainsKey(badgeIDNumber))
            {
                var doors = _dictionaryOfBadges[badgeIDNumber];
                return doors;
            }
            return null;
        }
        //Get all Badge numbers and cooresponding door access
        public Dictionary<int, List<string>> GetListOfAllBadges()
        {
            var DictionaryOfBadges = new Dictionary<int, List<string>>();
            return DictionaryOfBadges;

        }

    }
}
