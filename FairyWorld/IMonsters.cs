using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld
{
    internal interface ILowTierMonster : IMonster
    {
        public Skill MainSkill();
    }

    internal interface IMidTierMonster : ILowTierMonster
    {
        public Skill SideSkill();
    };

    internal interface IHighTierMonster : IMidTierMonster
    {
        public Skill[] SideSkills();
    };

    interface IFlyingMonster : IHighTierMonster
    {
        public Skill MainFlySkill();

        public Skill[] FlySideSkills();

        public Skill[] GetFlyingSkills();

        public int GetFlySpeed();

        public string FlyAnimation();
    };

    internal interface IHybridMonster : IFlyingMonster
    {
        public int GetAscendSpeed();
        public int GetDescendSpeed();
    }

    internal interface IFly
    {
        public string Fly();
    }

    internal interface IFinalBossMonster : IHighTierMonster
    {
        public string StageIncrement();
        public string StageDecrement();
    }
}
