using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Mosters.Factories
{
    internal class MechaLaserTagMonsterFactory : ILaserTagMonsterFactory
    {
        public ILowTierMonster CreateLowTierMonster()
        {
            return new MechaLowTierMonster(RandomWrapper.GetRanInt(1, 20));
        }

        public IMidTierMonster CreateMidTierMonster()
        {
            return new MechaMidTierMonster(RandomWrapper.GetRanInt(5, 30));
        }

        public IHighTierMonster CreateHighTierMonster()
        {
            return new MechaHighTierMonster(RandomWrapper.GetRanInt(15, 50));
        }

        public IFlyingMonster CreateFlyingMonster()
        {
            return new MechaFlyingMonster(RandomWrapper.GetRanInt(15, 50));
        }

        public IHybridMonster CreateHybridMonster()
        {
            return new MechaHybridMonster(RandomWrapper.GetRanInt(15, 50));
        }

        public IFinalBossMonster CreateFinalBossMonster()
        {
            return new MechaFinalBossMonster(RandomWrapper.GetRanInt(40, 100));
        }
    }
}
