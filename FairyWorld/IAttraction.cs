using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld
{
    internal interface IAttraction
    {
        public double KidFriendliness();

        public double TeenFriendliness();

        public double AdultFriendliness();

        public double Scarriness();

        public double Thrill();

        public double Laughter();

        public double Sightseeing();

        public double Comfortableness();

        public double AverageSpeedM();

        public double MaximumSpeed();

        public double MaximumWeight();

        public double MinimumHeight();

        public double MaximumHeight();

        public string Warnings();

        public string Description();

        public string Title();

        public string RideNarration(StateOfAffairs parkState);
    }
}
