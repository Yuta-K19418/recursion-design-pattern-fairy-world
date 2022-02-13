using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.RentalPets.Animals
{
    internal class Cat : Mammal, IPlayfulPet
    {
        internal const string SPECIES = "Cat";
        internal const double LIFE_EXPECTANCY = 5500;
        internal const double BODY_TEMPERATURE = 37;

        private const double PLAYFUL_HOURLY_COSTS = 50;
        private static readonly string[] LIKED_ACTIVITIES = {"eat","nap","groom","drink","crawl","explore","pet"};
        private static readonly string[] DISLIKED_ACTIVITIES = {"bath"};

        internal Cat(double heightM, double weightKg, string biologicalSex)
            : base(Cat.SPECIES, heightM, weightKg, Cat.LIFE_EXPECTANCY, biologicalSex, Cat.BODY_TEMPERATURE)
        {
        }

        internal override string GetString()
        {
            return base.GetString() + " this is a cat";
        }

        public void Meow()
        {
            Console.WriteLine("Meooow");
        }

        public string GetPetName()
        {
            return this.Species;
        }

        public string Play()
        {
            return "This cat starts rolling on the floor, and pretends to play predator";
        }

        public string PlayWithPerson(Person person)
        {
            var sb = new StringBuilder("The cat stares at " + person.GetName());
            sb.Append(". After taking kin to "
                + person.GetName()
                + ", "
                + person.GetName()
                + " throws a mouse toy at this cat and the cat starts chasing the mouse toy");
            return sb.ToString();
        }

        public string PlayNoise()
        {
            return "Meow";
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
                return "The cat enjoyed eating food.";
            }
            else if (activity == "nap")
            {
                this.Sleep();
                return "The cat took a good nap.";
            }
            else if (this.LikesActivity(activity))
            {
                return "Meow. The cat really enjoyed the " + activity + " activity.";
            }
            else if (this.LikesActivity(activity))
            {
                return "The cat really hated the " + activity + " activity.";
            }
            else
            {
                return "The cat felt indiferent about the " + activity + " activity.";
            }
        }
    }
}
