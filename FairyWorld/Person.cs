using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld
{
    internal class Person : Mammal, IStatus
    {
        private const string SPECIES = "Human";
        private const double LIFE_EXPECTANCY = 30000;
        private const double BODY_TEMPERATURE = 36;

        private Name name;
        private int age;

        private const string HAPPINESS = "Happiness";
        private const string ENERGY = "Energy";
        private const string NAUSEA = "Nausea";
        private const string BATHROOM = "Bathroom";
        private const string FRIGHTFUL = "Frightful";
        private string status = string.Empty;


        internal Person(string firstName, string lastName, int age, double heightM, double weightKg, string biologicalSex)
            : base(Person.SPECIES, heightM, weightKg, Person.LIFE_EXPECTANCY, biologicalSex, Person.BODY_TEMPERATURE)
        {
            this.name = new Name(firstName, lastName);
            this.age = age;
        }

        internal string GetName()
        {
            return this.name.GetString();
        }

        internal override string GetString()
        {
            return base.GetString() + ". The name of this Person is " + this.GetName();
        }

        public string GetHappiness()
        {
            return HAPPINESS;
        }

        public void SetHappiness()
        {
            status = HAPPINESS;
        }

        public string GetEnergy()
        {
            return ENERGY;
        }

        public void SetEnergy()
        {
            status = ENERGY;
        }

        public string GetNausea()
        {
            return NAUSEA;
        }
        
        public void SetNausea()
        {
            status = NAUSEA;
        }

        public string GetBathroom()
        {
            return BATHROOM;
        }

        public void SetBathroom()
        {
            status = BATHROOM;
        }

        public string GetFrightful()
        {
            return FRIGHTFUL;
        }

        public void SetFrightful()
        {
            status = FRIGHTFUL;
        }
    }
}
