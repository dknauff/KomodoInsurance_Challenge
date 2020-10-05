using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance_Challenge_ClassLibrary
{
    public class BadgeRepository
    {
        Dictionary<int, List<string>> _badgeDictionary = new Dictionary<int, List<string>>();

        public bool CreateNewBadge(int badgeID, List<string> doorAccess)
        {
            int startingCount = _badgeDictionary.Count;
            _badgeDictionary.Add(badgeID, doorAccess);
            bool wasAdded = (_badgeDictionary.Count > startingCount) ? true : false;
            return wasAdded;
        }
       
        public Dictionary<int, List<string>> GetAllBadges()
        {
            return _badgeDictionary;
        }

        public Badge GetBadgeByID(int badgeID)
        {
            foreach (Badge singleBadge in _badgeDictionary.Keys)
            {
                if (singleBadge.BadgeID == badgeID)
                {
                    return singleBadge;
                }
            }
            return null;
        }

        public bool UpdateExisitingBadgeDoors(string newDoorAccess)
        {

        }

        public bool DeleteAllDoorsOnSingleBadge()
        {

        }


    }
}
