using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld
{
    internal class RandomWrapper
    {
        public static int GetRanInt(int min, int max)
        {
            var r = new Random();
            return min + (r.Next() * ((max - min) + 1));
        }

        internal static double GetRanDouble(double min, double max)
        {
            var r = new Random();
            return min + (max - min) * r.NextDouble();
        }

        internal static bool RanBoolean()
        {
            var r = new Random();
            return r.Next(2) == 1;
        }
    }

    internal class BMI
    {
        private double heightM;
        private double weightKg;

        internal BMI(double heightM, double weightKg)
        {
            this.heightM = heightM;
            this.weightKg = weightKg;
        }

        internal double GetWeightKg()
        {
            return this.weightKg;
        }

        internal double GetValue()
        {
            return this.weightKg / (this.heightM * this.heightM);
        }

        internal string GetString()
        {
            return this.heightM + " meters, " + this.weightKg + "kg, BMI:" + this.GetValue();
        }
    }

    internal class Name
    {
        private string firstName;
        private string lastName;

        internal Name(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        internal string GetString()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
