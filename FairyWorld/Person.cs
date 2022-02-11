using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld
{
    internal class Person : Mammal
    {
        internal static string SPECIES = "Human";
        internal static double LIFE_EXPECTANCY = 30000;
        internal static double BODY_TEMPERATURE = 36;

        private Name name;
        private int age;

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
    }
}
