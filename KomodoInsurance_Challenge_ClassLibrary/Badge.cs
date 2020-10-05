﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance_Challenge_ClassLibrary
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public string DoorAccess { get; set; }

        public Badge() { }
        public Badge(int badgeID, string doorAccess)
        {
            BadgeID = badgeID;
            DoorAccess = doorAccess;
        }
    }
}
