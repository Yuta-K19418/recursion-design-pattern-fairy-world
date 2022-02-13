using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Mosters
{
    internal class MechaLowTierMonster : LaserLowTierMonster
    {
        internal MechaLowTierMonster(int hp, int attack, int defense, int level, int points, int movementSpeed)
            : base(hp, attack, defense, level, points, movementSpeed)
        {
        }

        internal MechaLowTierMonster(int level)
            : base(level)
        {
        }

        public string GetMonsterName()
        {
            return "Mecha Low Tier Monster";
        }
    }

    internal class MechaMidTierMonster : LaserMidTierMonster
    {

        internal MechaMidTierMonster(int hp, int attack, int defense, int level, int points, int movementSpeed)
            : base(hp, attack, defense, level, points, movementSpeed)
        {
        }

        internal MechaMidTierMonster(int level)
            : base(level)
        {
        }

        public string GetMonsterName()
        {
            return "Mecha Mid Tier Monster";
        }
    }

    internal class MechaHighTierMonster : LaserHighTierMonster
    {
        internal MechaHighTierMonster(int hp, int attack, int defense, int level, int points, int movementSpeed)
            : base(hp, attack, defense, level, points, movementSpeed)
        {
        }

        internal MechaHighTierMonster(int level)
            : base(level)
        {
        }

        public string GetMonsterName()
        {
            return "Mecha High Tier Monster";
        }
    }

    internal class MechaFlyingMonster : LaserFlyingMonster
    {
        internal MechaFlyingMonster(int hp, int attack, int defense, int level, int points, int movementSpeed, int flyingSpeed)
            : base(hp, attack, defense, level, points, movementSpeed, flyingSpeed)
        {
        }

        internal MechaFlyingMonster(int level)
            : base(level)
        {
        }

        public string GetMonsterName()
        {
            return "Mecha Flying Monster";
        }
    }

    internal class MechaHybridMonster : LaserHybridMonster
    {
        internal MechaHybridMonster(int hp, int attack, int defense, int level, int points, int movementSpeed, int flyingSpeed, int ascendSpeed, int descendSpeed)
            : base(hp, attack, defense, level, points, movementSpeed, flyingSpeed, ascendSpeed, descendSpeed)
        {
        }

        internal MechaHybridMonster(int level)
            : base(level)
        {
        }

        public string GetMonsterName()
        {
            return "Mecha Hybrid Monster";
        }
    }

    internal class MechaFinalBossMonster : LaserFinalBossMonster
    {
        internal MechaFinalBossMonster(int hp, int attack, int defense, int level, int points, int movementSpeed)
            : base(hp, attack, defense, level, points, movementSpeed)
        {

        }

        internal MechaFinalBossMonster(int level)
            : base(level)
        {
        }

        public string GetMonsterName()
        {
            return "Mecha Final Boss Monster";
        }
    }
}
