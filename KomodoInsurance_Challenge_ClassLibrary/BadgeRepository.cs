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

        public List<string> GetDoorListByID(int badgeID)
        {
            foreach (KeyValuePair<int, List<string>> singleBadge in _badgeDictionary)
            {
                if (singleBadge.Key == badgeID)
                {
                    return singleBadge.Value;
                }
            }
            return null;
        }

        public int GetBadgeByID(int badgeID)
        {
            foreach (KeyValuePair<int, List<string>> singleBadge in _badgeDictionary)
            {
                if (singleBadge.Key == badgeID)
                {
                    return singleBadge.Key;
                }
            }
            return 0;
        }
    }
}
