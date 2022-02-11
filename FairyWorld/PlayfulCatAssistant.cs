using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld
{
    internal class PlayfulCatAssistant : PlayfulPetAssistant
    {
        protected override IPlayfulPet CreatePlayfulPet()
        {
            return new Cat(RandomWrapper.GetRanDouble(0.15, 0.3),
                RandomWrapper.GetRanDouble(2.0, 4.9),
                RandomWrapper.RanBoolean() ? "male" : "female");
        }
    }
}
