using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld
{
    internal class Dog : Mammal, IPlayfulPet
    {
        public const string SPECIES = "Dog";
        public const double LIFE_EXPECTANCY = 4800;
        public const double BODY_TEMPERATURE = 39;

        private const double PLAYFUL_HOURLY_COSTS = 35;
        private static readonly string[] LIKED_ACTIVITIES = {"eat","nap","chase","swim","drink","run","explore","pet"};
        private static readonly string[] DISLIKED_ACTIVITIES = {"hug","dressup"};

        internal Dog(double heightM, double weightKg, string biologicalSex)
            : base(Dog.SPECIES, heightM, weightKg, Dog.LIFE_EXPECTANCY, biologicalSex, Dog.LIFE_EXPECTANCY)
        {
        }

        internal override string GetString()
        {
            return base.GetString() + " this is a dog";
        }

        public void Woof()
        {
            Console.WriteLine("Woof Woof");
        }

        public string GetPetName()
        {
            return this.Species;
        }

        public string Play()
        {
            return "This dog starts running on the park and chases a ball.";
        }

        public string PlayWithPerson(Person person)
        {
            var sb = new StringBuilder("The dog runs towards " + person.GetName());
            sb.Append(". After the dog taking kin to " + person.GetName() + ", " + person.GetName() + " throws a frisbee disk and the dog chases it.");
            return sb.ToString();
        }

        public string PlayNoise()
        {
            return "Wooooof Woooof";
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
                return "The dog ate the entire food in a few bites.";
            }
            else if (activity == "nap")
            {
                this.Sleep();
                return "The dog took a quick nap.";
            }
            else if (this.LikesActivity(activity))
            {
                return "Woof Woof. The dog really enjoyed the " + activity + " activity.";
            }
            else if (this.LikesActivity(activity))
            {
                return "The dog did not like " + activity + " activity. The dog walked away";
            }
            else
            {
                return "The dog felt indiferent about the " + activity + " activity.";
            }
        }
    }
}
