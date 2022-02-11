using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld
{
    internal abstract class PlayfulPetAssistant
    {
        protected static double DEFAULT_RENT_TIME = 1.0;
        protected static string DEFAULT_TOUR = "all-rounder pack";

        protected Person? CurrentPerson;
        protected double CurrentRentTime = PlayfulPetAssistant.DEFAULT_RENT_TIME;
        protected static string[] AvailableActivities = { "eat", "walk", "drink", "nap", "pet", "run", "explore" };
        protected static string[] AvailableTours = { "all-rounder pack", "deluxe rounder pack" };

        public string[] GetActivities()
        {
            return AvailableActivities;
        }

        public string[] GetAvailableTours()
        {
            return AvailableTours;
        }

        public bool IsValidTour(string tour)
        {
            return this.GetAvailableTours().Contains(tour);
        }

        public string GetRandomActivity()
        {
            var activities = this.GetActivities().ToList();
            int ran = new Random().Next(activities.Count());
            return activities[ran];
        }

        public void SetPerson(Person person)
        {
            this.CurrentPerson = person;
        }

        public void SetHours(double hours)
        {
            this.CurrentRentTime = hours;
        }

        public double GetCurrentRentTime()
        {
            return this.CurrentRentTime;
        }

        public void Reset()
        {
            this.CurrentPerson = null;
            this.CurrentRentTime = DEFAULT_RENT_TIME;
        }

        public double RunAssistanceTour(Person person)
        {
            return this.RunAssistanceTour(person, DEFAULT_TOUR);
        }

        public double RunAssistanceTour(Person person, String tour)
        {
            if (!this.IsValidTour(tour))
            {
                Console.WriteLine("The tour guide does not accept the " + tour + " tour.");
            }

            var playfulPet = this.CreatePlayfulPet();

            Console.WriteLine("");
            Console.WriteLine("Booting up... Playful Pet Assistance robot at your service.");
            Console.WriteLine("Printing information about the Person to service..." + person);
            Console.WriteLine("");
            Console.WriteLine("Printing information about the Playful Pet - " + playfulPet.GetPetName() + " to service..." + playfulPet);

            if (tour == "all-rounder pack" || tour == "deluxe rounder pack")
            {
                int count = tour == "all-rounder pack" ? 1 : 3;
                this.GenericRounderTour(count, person, playfulPet);
            }
            else
            {
                Console.WriteLine("The tour assistant robot for " + playfulPet.GetPetName() + " and " + person.GetName() + " did nothing.");
            }

            double rentalCosts = playfulPet.GetRentalCosts() * this.GetCurrentRentTime();

            this.Reset();

            return rentalCosts;
        }

        private void GenericRounderTour(int activityCount, Person person, IPlayfulPet pet)
        {
            Console.WriteLine();
            Console.WriteLine("Now starting the generic rounder tour with " + activityCount + " activity(s)");
            Console.WriteLine(person.GetName() + " greets " + pet.GetPetName());
            Console.WriteLine();
            Console.WriteLine(pet.Play());
            Console.WriteLine();
            Console.WriteLine(pet.PlayNoise());
            Console.WriteLine();
            Console.WriteLine(pet.PlayWithPerson(person));
            Console.WriteLine();

            for (int i = 0; i < activityCount; i++)
            {
                String activity = this.GetRandomActivity();
                Console.WriteLine(pet.GetPetName() + " will now " + activity);
                Console.WriteLine("--------");
                Console.WriteLine(pet.DoActivity(activity));
                Console.WriteLine("--------");
                Console.WriteLine();
            }
        }

        protected abstract IPlayfulPet CreatePlayfulPet();
    }
}
