using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld
{
    internal class Animal
    {
        protected string Species;

        protected BMI Bmi;

        protected double LifeSpanDays;

        protected string BiologicalSex;

        protected DateTime SpawnTime;

        protected DateTime? DeathTime;

        protected int HungerPercent = 100;

        protected int SleepPercent = 100;

        internal Animal(string species, double heightM, double weightKg, double lifeSpanDays, string biologicalSex)
        {
            this.Species = species;
            this.Bmi = new BMI(heightM, weightKg);
            this.LifeSpanDays = lifeSpanDays;
            this.BiologicalSex = biologicalSex;
            this.SpawnTime = new DateTime();
        }

        internal virtual void Eat()
        {
            if (!this.IsAlive())
            {
                return;
            }
            this.HungerPercent = 0;
        }

        internal virtual void SetAsHungry()
        {
            if (!this.IsAlive())
            {
                return;
            }
            this.HungerPercent = 100;
        }

        internal virtual bool IsHungry()
        {
            return this.HungerPercent >= 70;
        }

        internal virtual void Sleep()
        {
            if (!this.IsAlive())
            {
                return;
            }
            this.SleepPercent = 0;
        }

        internal virtual void SetAsSleepy()
        {
            if (!this.IsAlive())
            {
                return;
            }
            this.SleepPercent = 100;
        }

        internal virtual bool IsSleepy()
        {
            return this.SleepPercent >= 70;
        }

        internal virtual void Die()
        {
            this.SleepPercent = 0;
            this.HungerPercent = 0;
            this.DeathTime = new DateTime();
        }

        internal virtual bool IsAlive()
        {
            return this.DeathTime == null;
        }

        internal virtual string GetString()
        {
            return this.Species + " " + this.Bmi + " lives " + this.LifeSpanDays + " days/" + "gender:" + this.BiologicalSex + "." + this.Status();
        }

        internal virtual string Status()
        {
            return this.Species + " status:" + " Hunger - " + this.HungerPercent + "%, " + "sleepiness:" + this.SleepPercent + "%" + ", Alive - " + this.IsAlive() + ". First created at " + this.DateCreated();
        }

        internal virtual string DateCreated()
        {
            return this.SpawnTime.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
