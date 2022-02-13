using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld
{
    internal interface ILaserTagMonsterFactory
    {
        public ILowTierMonster CreateLowTierMonster();
        public IMidTierMonster CreateMidTierMonster();
        public IHighTierMonster CreateHighTierMonster();
        public IFlyingMonster CreateFlyingMonster();
        public IHybridMonster CreateHybridMonster();
        public IFinalBossMonster CreateFinalBossMonster();
    }
}
