using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld
{
    internal class Rabbit : Mammal, IPlayfulPet
    {
        internal const string SPECIES = "Rabbit";
        internal const double LIFE_EXPECTANCY = 3000;
        internal const double BODY_TEMPERATURE = 40;

        private const double PLAYFUL_HOURLY_COSTS = 30;
        private static readonly string[] LIKED_ACTIVITIES = {"eat","nap","chase","drink","jump","dig"};
        private static readonly string[] DISLIKED_ACTIVITIES = {"bath","dressup"};

        internal Rabbit(double heightM, double weightKg, string biologicalSex)
            : base(Rabbit.SPECIES, heightM, weightKg, Rabbit.LIFE_EXPECTANCY, biologicalSex, Rabbit.LIFE_EXPECTANCY)
        {
        }

        internal override string GetString()
        {
            return base.GetString() + " this is a rabbit";
        }

        public void Woof()
        {
            Console.WriteLine("Squeak Squeak");
        }

        public string GetPetName()
        {
            return this.Species;
        }

        public string Play()
        {
            return "This rabbit starts jumping around and chases an insect on the grass.";
        }

        public string PlayWithPerson(Person person)
        {
            var sb = new StringBuilder("The bunny hops towards " + person.GetName());
            sb.Append(". After the rabbit stares at " + person.GetName() + ", " + person.GetName() + " makes the rabbit chase a small carrot. The rabbit hops towards it.");
            return sb.ToString();
        }

        public string PlayNoise()
        {
            return "Squeak";
        }

        public double GetRentalCosts()
        {
            return PLAYFUL_HOURLY_COSTS;
        }

        public bool LikesActivity(string activity)
        {
            return LIKED_ACTIVITIES.Contains(activity);
        }

        public bool DislikesActivity(string activity)
        {
            return DISLIKED_ACTIVITIES.Contains(activity);
        }

        public string DoActivity(string activity)
        {
            if (activity == "eat")
            {
                this.Eat();
                return "The rabbit chew on the food bit by bit taking tiny bites.";
            }
            else if (activity == "nap")
            {
                this.Sleep();
                return "The rabbit took a long nap.";
            }
            else if (this.LikesActivity(activity))
            {
                return ".... The Rabbit really enjoyed the " + activity + " activity.";
            }
            else if (this.LikesActivity(activity))
            {
                return "Squeeeak. The Rabbit did not like " + activity + " activity. The rabbit quickly hopped away";
            }
            else
            {
                return "The rabbit felt indiferent about the " + activity + " activity.";
            }
        }
    }
}
