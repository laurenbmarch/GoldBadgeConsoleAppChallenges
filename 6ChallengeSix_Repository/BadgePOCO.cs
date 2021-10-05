using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ChallengeSix_Repository
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public List<string> ListOfDoorNames { get; set; } = new List<string>();
        public string BadgeName { get; set; }

        public Badge() { }
        public Badge(int badgeID, string badgeName, List<string> listOfDoorNames)
        {
            BadgeID = badgeID;
            BadgeName = badgeName;
            ListOfDoorNames = listOfDoorNames;
        }
    }

    

}
