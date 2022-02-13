using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Mosters.Factories
{
    internal class AntarcticaLaserTagMonsterFactory : ILaserTagMonsterFactory
    {
        public ILowTierMonster CreateLowTierMonster()
        {
            return new AntarcticaLowTierMonster(RandomWrapper.GetRanInt(1, 20));
        }

        public IMidTierMonster CreateMidTierMonster()
        {
            return new AntarcticaMidTierMonster(RandomWrapper.GetRanInt(5, 30));
        }

        public IHighTierMonster CreateHighTierMonster()
        {
            return new AntarcticaHighTierMonster(RandomWrapper.GetRanInt(15, 50));
        }

        public IFlyingMonster CreateFlyingMonster()
        {
            return new AntarcticaFlyingMonster(RandomWrapper.GetRanInt(15, 50));
        }

        public IHybridMonster CreateHybridMonster()
        {
            return new AntarcticaHybridMonster(RandomWrapper.GetRanInt(15, 50));
        }

        public IFinalBossMonster CreateFinalBossMonster()
        {
            return new AntarcticaFinalBossMonster(RandomWrapper.GetRanInt(40, 100));
        }
    }
}
