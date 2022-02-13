using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Mosters.Factories
{
    internal class GenericLaserTagMonsterFactory : ILaserTagMonsterFactory
    {
        public ILowTierMonster CreateLowTierMonster()
        {
            return new LaserLowTierMonster(RandomWrapper.GetRanInt(1, 20));
        }

        public IMidTierMonster CreateMidTierMonster()
        {
            return new LaserMidTierMonster(RandomWrapper.GetRanInt(5, 30));
        }

        public IHighTierMonster CreateHighTierMonster()
        {
            return new LaserHighTierMonster(RandomWrapper.GetRanInt(15, 50));
        }

        public IFlyingMonster CreateFlyingMonster()
        {
            return new LaserFlyingMonster(RandomWrapper.GetRanInt(15, 50));
        }

        public IHybridMonster CreateHybridMonster()
        {
            return new LaserHybridMonster(RandomWrapper.GetRanInt(15, 50));
        }

        public IFinalBossMonster CreateFinalBossMonster()
        {
            return new LaserFinalBossMonster(RandomWrapper.GetRanInt(40, 100));
        }
    }
}
