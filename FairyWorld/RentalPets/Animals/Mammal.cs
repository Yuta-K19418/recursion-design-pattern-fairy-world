using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.RentalPets.Animals
{
    internal class Mammal : Animal
    {
        private double bodyTemperatureC;
        private double avgBodyTemperatureC;

        internal Mammal(string species, double heightM, double weightKg, double lifeSpanDays, string biologicalSex, double avgBodyTemperatureC)
            : base(species, heightM, weightKg, lifeSpanDays, biologicalSex)
        {
            this.avgBodyTemperatureC = avgBodyTemperatureC;
            this.bodyTemperatureC = this.avgBodyTemperatureC;
        }

        internal override void Eat()
        {
            base.Eat();
            Console.WriteLine("this " + this.Species + " is eating with its single lower jaw");
        }

        internal override string GetString()
        {
            return base.GetString() + " " + this.MammalInformation();
        }

        internal void IncreaseBodyHeat(double celcius)
        {
            this.bodyTemperatureC += celcius;
        }

        internal void DecreaseBodyHeat(double celcius)
        {
            this.bodyTemperatureC -= celcius;
        }

        internal void AdjustBodyHeat()
        {
            this.bodyTemperatureC = this.avgBodyTemperatureC;
        }

        internal string MammalInformation()
        {
            return "This is a mammal with a temperature of: " + this.bodyTemperatureC;
        }
    }
}
