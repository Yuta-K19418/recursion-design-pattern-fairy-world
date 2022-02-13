using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld
{
    internal class AntarcticaLowTierMonster : LaserLowTierMonster
    {
        internal AntarcticaLowTierMonster(int hp, int attack, int defense, int level, int points, int movementSpeed)
            : base(hp, attack, defense, level, points, movementSpeed)
        {
        }

        internal AntarcticaLowTierMonster(int level)
            : base(level)
        {
        }

        public string GetMonsterName()
        {
            return "Antarctica Ice Low Tier Monster";
        }
    }

    internal class AntarcticaMidTierMonster : LaserMidTierMonster
    {

        internal AntarcticaMidTierMonster(int hp, int attack, int defense, int level, int points, int movementSpeed)
            : base(hp, attack, defense, level, points, movementSpeed)
        {
        }

        internal AntarcticaMidTierMonster(int level)
            : base(level)
        {
        }

        public string GetMonsterName()
        {
            return "Antarctica Ice Mid Tier Monster";
        }
    }

    internal class AntarcticaHighTierMonster : LaserHighTierMonster
    {
        internal AntarcticaHighTierMonster(int hp, int attack, int defense, int level, int points, int movementSpeed)
            : base(hp, attack, defense, level, points, movementSpeed)
        {
        }

        internal AntarcticaHighTierMonster(int level)
            : base(level)
        {
        }

        public string GetMonsterName()
        {
            return "Antarctica Ice High Tier Monster";
        }
    }

    internal class AntarcticaFlyingMonster : LaserFlyingMonster
    {
        internal AntarcticaFlyingMonster(int hp, int attack, int defense, int level, int points, int movementSpeed, int flyingSpeed)
            : base(hp, attack, defense, level, points, movementSpeed, flyingSpeed)
        {
        }

        internal AntarcticaFlyingMonster(int level)
            : base(level)
        {
        }

        public string GetMonsterName()
        {
            return "Antarctica Ice Flying Monster";
        }
    }

    internal class AntarcticaHybridMonster : LaserHybridMonster
    {
        internal AntarcticaHybridMonster(int hp, int attack, int defense, int level, int points, int movementSpeed, int flyingSpeed, int ascendSpeed, int descendSpeed)
            : base(hp, attack, defense, level, points, movementSpeed, flyingSpeed, ascendSpeed, descendSpeed)
        {
        }

        internal AntarcticaHybridMonster(int level)
            : base(level)
        {
        }

        public string GetMonsterName()
        {
            return "Antarctica Ice Hybrid Monster";
        }
    }

    internal class AntarcticaFinalBossMonster : LaserFinalBossMonster
    {
        internal  AntarcticaFinalBossMonster(int hp, int attack, int defense, int level, int points, int movementSpeed)
            : base(hp, attack, defense, level, points, movementSpeed)
        {

        }

        internal AntarcticaFinalBossMonster(int level)
            : base(level)
        {
        }

        public string GetMonsterName()
        {
            return "Antarctica Ice Final Boss Monster";
        }
    }
}
