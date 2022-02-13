using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Attractions
{
    internal class FamilyCoasters : IAttraction
    {
        private const double KID_FRIENDLINESS = 90;
        private const double TEEN_FRIENDLINESS = 40;
        private const double ADULT_FRIENDLINESS = 70;
        private const double SCARRINESS = 30;
        private const double THRILL = 30;
        private const double LAUGHTER = 40;
        private const double SIGHTSEEING = 40;
        private const double COMFORTABLENESS = 60;
        private const double AVERAGE_SPEED_M = 50;
        private const double MAXIMUM_SPEED = 70;
        private const double MAXIMUM_WEIGHT = 100;
        private const double MINIMUM_HEIGHT = 100;
        private const double MAXIMUM_HEIGHT = 190;
        private const string TITLE = "Family Coasters";

        public double KidFriendliness()
        {
            return KID_FRIENDLINESS;
        }

        public double TeenFriendliness()
        {
            return TEEN_FRIENDLINESS;
        }

        public double AdultFriendliness()
        {
            return ADULT_FRIENDLINESS;
        }

        public double Scarriness()
        {
            return SCARRINESS;
        }

        public double Thrill()
        {
            return THRILL;
        }

        public double Laughter()
        {
            return LAUGHTER;
        }

        public double Sightseeing()
        {
            return SIGHTSEEING;
        }

        public double Comfortableness()
        {
            return COMFORTABLENESS;
        }

        public double AverageSpeedM()
        {
            return AVERAGE_SPEED_M;
        }

        public double MaximumSpeed()
        {
            return MAXIMUM_SPEED;
        }

        public double MaximumWeight()
        {
            return MAXIMUM_WEIGHT;
        }

        public double MinimumHeight()
        {
            return MINIMUM_HEIGHT;
        }

        public double MaximumHeight()
        {
            return MAXIMUM_HEIGHT;
        }

        public string Warnings()
        {
            return "Acrophobia";
        }

        public string Description()
        {
            return "Anyone can enjoy!";
        }

        public string Title()
        {
            return TITLE;
        }

        public string RideNarration(StateOfAffairs parkState)
        {
            var sb = new StringBuilder();
            sb.Append($"Now: {parkState.DT}, NumberOfPeople: {parkState.NumberOfPeople}, Temperature: {parkState.Temperature},");
            sb.Append($"SoundLevel: {parkState.SoundLevel}, Atmosphere: {parkState.Atmosphere}");
            return sb.ToString();
        }
    }

    internal class InvertedCoasters : IAttraction
    {
        private const double KID_FRIENDLINESS = 30;
        private const double TEEN_FRIENDLINESS = 70;
        private const double ADULT_FRIENDLINESS = 80;
        private const double SCARRINESS = 60;
        private const double THRILL = 70;
        private const double LAUGHTER = 50;
        private const double SIGHTSEEING = 60;
        private const double COMFORTABLENESS = 20;
        private const double AVERAGE_SPEED_M = 100;
        private const double MAXIMUM_SPEED = 200;
        private const double MAXIMUM_WEIGHT = 100;
        private const double MINIMUM_HEIGHT = 130;
        private const double MAXIMUM_HEIGHT = 200;
        private const string TITLE = "Inverted Coasters";

        public double KidFriendliness()
        {
            return KID_FRIENDLINESS;
        }

        public double TeenFriendliness()
        {
            return TEEN_FRIENDLINESS;
        }

        public double AdultFriendliness()
        {
            return ADULT_FRIENDLINESS;
        }

        public double Scarriness()
        {
            return SCARRINESS;
        }

        public double Thrill()
        {
            return THRILL;
        }

        public double Laughter()
        {
            return LAUGHTER;
        }

        public double Sightseeing()
        {
            return SIGHTSEEING;
        }

        public double Comfortableness()
        {
            return COMFORTABLENESS;
        }

        public double AverageSpeedM()
        {
            return AVERAGE_SPEED_M;
        }

        public double MaximumSpeed()
        {
            return MAXIMUM_SPEED;
        }

        public double MaximumWeight()
        {
            return MAXIMUM_WEIGHT;
        }

        public double MinimumHeight()
        {
            return MINIMUM_HEIGHT;
        }

        public double MaximumHeight()
        {
            return MAXIMUM_HEIGHT;
        }

        public string Warnings()
        {
            return "Acrophobia, Pregnancy, Neck problems";
        }

        public string Description()
        {
            return "Feel the thrill!";
        }

        public string Title()
        {
            return TITLE;
        }

        public string RideNarration(StateOfAffairs parkState)
        {
            throw new NotImplementedException();
        }
    }
}
