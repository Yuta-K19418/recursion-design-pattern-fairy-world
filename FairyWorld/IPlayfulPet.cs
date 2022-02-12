using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld
{
    internal interface IPlayfulPet
    {
        public string Play();
        public string PlayWithPerson(Person person);
        public string PlayNoise();
        public string GetPetName();
        public double GetRentalCosts();
        public bool LikesActivity(string activity);
        public bool DislikesActivity(string activity);
        public string DoActivity(string activity);
    }
}
