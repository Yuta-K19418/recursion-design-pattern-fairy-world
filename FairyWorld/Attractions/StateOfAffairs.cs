using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Attractions
{
    internal class StateOfAffairs
    {
        internal DateTime DT;

        internal int NumberOfPeople;

        internal int Temperature;

        internal int SoundLevel;

        internal string Atmosphere;

        internal StateOfAffairs(int numberOfPeople, int temperature, int soundLevel, string atmosphere)
        {
            this.DT = DateTime.Now;
            this.NumberOfPeople = numberOfPeople;
            this.Temperature = temperature;
            this.SoundLevel = soundLevel;
            this.Atmosphere = atmosphere;
        }
    }
}
