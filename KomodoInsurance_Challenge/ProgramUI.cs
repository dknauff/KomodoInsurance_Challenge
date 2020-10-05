using KomodoInsurance_Challenge_ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance_Challenge
{
    class ProgramUI
    {
        private readonly BadgeRepository _badgeRepository = new BadgeRepository();
        public void Run()
        {
            SeedBadges();
            RunMenu();
        }

        private void RunMenu()
        {

        }

        private void SeedBadges()
        {
            Badge badge1 = new Badge(12345, new List<string>() { "a1" });
            //enter rest of badges
        }
    }
}
