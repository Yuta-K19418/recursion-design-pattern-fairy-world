using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld
{
    internal abstract class RideExperience
    {
        public void Ride(Person person, StateOfAffairs state)
        {
            var attraction = CreateRide();
            SetPersonStatus(person);
            Console.WriteLine();
            Console.WriteLine("--------");
            Console.WriteLine($"The name of the attraction: {attraction.Title()}");
            Console.WriteLine($"Explanation about attraction: {attraction.Description()}");
            Console.WriteLine($"Satisfaction with the attraction for children: {attraction.KidFriendliness()}%");
            Console.WriteLine($"Satisfaction with the attraction for teens: {attraction.TeenFriendliness()}%");
            Console.WriteLine($"Satisfaction of the attraction for adults: {attraction.AdultFriendliness()}%");
            Console.WriteLine($"Fear of the attraction: {attraction.Scarriness()}%");
            Console.WriteLine($"The thrill of the attraction: {attraction.Thrill()}%");
            Console.WriteLine($"Interestingness of the attraction: {attraction.Laughter()}%");
            Console.WriteLine($"Viewing degree of the attraction: {attraction.Sightseeing()}%");
            Console.WriteLine($"Attraction comfort: {attraction.Comfortableness()}%");
            Console.WriteLine("--------");
            Console.WriteLine($"Average speed of the attraction: {attraction.AverageSpeedM()}km/h");
            Console.WriteLine($"Maximum speed of the attraction: {attraction.MaximumSpeed()}km/h");
            Console.WriteLine($"Maximum weight supported by the attraction: {attraction.MaximumWeight()}kg");
            Console.WriteLine($"Minimum height supported by the attraction: {attraction.MinimumHeight()}cm");
            Console.WriteLine($"Maximum height supported by the attraction: {attraction.MaximumHeight()}cm");
            Console.WriteLine($"A warning that the attraction outputs as a string." +
                $"Includes warnings like health, seizures, claustrophobia, pregnancy, neck problems: {attraction.Warnings()}");
            Console.WriteLine("--------");
            Console.WriteLine($"{attraction.RideNarration(state)}");
            Console.WriteLine($"Person Status: {GetPersonStatus(person)}");
            Console.WriteLine();
        }

        protected abstract IAttraction CreateRide();

        protected abstract void SetPersonStatus(Person person);

        protected abstract string GetPersonStatus(Person person);
    }
}
