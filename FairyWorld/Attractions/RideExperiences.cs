using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Attractions
{
    internal class RideFamilyCoastersExperience : RideExperience
    {
        protected override IAttraction CreateRide()
        {
            return new FamilyCoasters();
        }

        protected override void SetPersonStatus(Person person)
        {
            person.SetHappiness();
        }

        protected override string GetPersonStatus(Person person)
        {
            return person.GetHappiness();
        }
    }

    internal class RideInvertedCoastersExperience : RideExperience
    {
        protected override IAttraction CreateRide()
        {
            return new InvertedCoasters();
        }

        protected override void SetPersonStatus(Person person)
        {
            person.SetFrightful();
        }

        protected override string GetPersonStatus(Person person)
        {
            return person.GetFrightful();
        }
    }
}
