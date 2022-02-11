using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld
{
    internal interface IPlayfulPet
    {
        public abstract string Play();
        public abstract string PlayWithPerson(Person person);
        public abstract string PlayNoise();
        public abstract string GetPetName();
        public abstract double GetRentalCosts();
        public abstract bool LikesActivity(string activity);
        public abstract bool DislikesActivity(string activity);
        public abstract string DoActivity(string activity);
    }
}
