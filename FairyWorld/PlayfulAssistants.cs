﻿using System;
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

    internal class PlayfulDogAssistant : PlayfulPetAssistant
    {
        protected override IPlayfulPet CreatePlayfulPet()
        {
            return new Dog(RandomWrapper.GetRanDouble(0.15, 1.3),
                RandomWrapper.GetRanDouble(9.5, 25.8),
                RandomWrapper.RanBoolean() ? "male" : "female");
        }
    }

    internal class PlayfulRabbitAssistant : PlayfulPetAssistant
    {
        protected override IPlayfulPet CreatePlayfulPet()
        {
            return new Rabbit(RandomWrapper.GetRanDouble(0.15, 0.4),
                RandomWrapper.GetRanDouble(2.2, 10.2),
                RandomWrapper.RanBoolean() ? "male" : "female");
        }
    }
}