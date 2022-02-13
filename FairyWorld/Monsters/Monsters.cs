using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Mosters
{
    internal class LaserMonster : IMonster
    {
        protected static readonly int[] MULTIPLIERS = { 100, 20, 30, 5, 1 };
        protected string MonsterName = string.Empty;
        protected int HP;
        protected int Attack;
        protected int Defense;
        protected int Level;
        protected int Points;
        protected int MovementSpeed;
        protected Skill[] SpecialSkills = new Skill[0];

        internal LaserMonster(int hp, int attack, int defense, int level, int points, int movementSpeed)
        {
            this.HP = hp;
            this.Attack = attack;
            this.Defense = defense;
            this.Level = level;
            this.Points = points;
            this.MovementSpeed = movementSpeed;

            this.SetInitialSkills();
        }

        internal LaserMonster(int level)
        {
            this.HP = level * LaserMonster.MULTIPLIERS[0];
            this.Attack = level * LaserMonster.MULTIPLIERS[1];
            this.Defense = level * LaserMonster.MULTIPLIERS[2];
            this.Level = level;
            this.Points = level * level * LaserMonster.MULTIPLIERS[3];
            this.MovementSpeed = level * LaserMonster.MULTIPLIERS[4];

            this.SetInitialSkills();
        }

        protected virtual void SetInitialSkills()
        {
            Skill[] skills = { new Skill(this.Attack, "Generic attack") };
            this.SetSpecialSkills(skills);
        }

        protected void SetSpecialSkills(Skill[] skills)
        {
            this.SpecialSkills = skills;
        }

        public int GetHP()
        {
            return this.HP;
        }

        public int GetAttack()
        {
            return this.Attack;
        }

        public int GetDefense()
        {
            return this.Defense;
        }

        public int GetPoints()
        {
            return this.Points;
        }

        public int GetLevel()
        {
            return this.Level;
        }

        public int GetMovementSpeed()
        {
            return this.MovementSpeed;
        }

        public string Kill()
        {
            this.HP = 0;
            return this.GetString() + " died. The body drops and disappears from the screen in 2 seconds.";
        }

        public Skill[] GetSpecialSkill()
        {
            return this.SpecialSkills;
        }

        public string GetMonsterName()
        {
            return "Generic Monster";
        }

        public string GetAppearance()
        {
            return "Grey block monster with a ? as its texture.";
        }

        public string GetString()
        {
            return this.GetMonsterName()
            + " hp-" + this.HP
            + "/atk-" + this.Attack
            + "/def-" + this.Defense
            + "/lvl-" + this.Level;
        }
    }

    internal class LaserLowTierMonster : LaserMonster, ILowTierMonster
    {
        internal LaserLowTierMonster(int hp, int attack, int defense, int level, int points, int movementSpeed)
                : base(hp, attack, defense, level, points, movementSpeed)
        {
        }

        internal LaserLowTierMonster(int level)
                : base(level)
        {
        }

        public Skill MainSkill()
        {
            return this.SpecialSkills[0];
        }

        internal string GetMonsterName()
        {
            return "Generic Low Tier Monster";
        }
    }

    internal class LaserMidTierMonster : LaserLowTierMonster, IMidTierMonster
    {

        internal LaserMidTierMonster(int hp, int attack, int defense, int level, int points, int movementSpeed)
            : base(hp, attack, defense, level, points, movementSpeed)
        {
        }

        internal LaserMidTierMonster(int level)
            : base(level)
        {
        }

        public Skill SideSkill()
        {
            return this.SpecialSkills[0];
        }

        protected override void SetInitialSkills()
        {
            Skill[] s = { new Skill(this.Attack, "Generic attack"), new Skill(this.Attack * 2, "Generic side attack") };
            this.SetSpecialSkills(s);
        }

        public string GetMonsterName()
        {
            return "Generic Mid Tier Monster";
        }
    }

    internal class LaserHighTierMonster : LaserMidTierMonster, IHighTierMonster
    {
        internal LaserHighTierMonster(int hp, int attack, int defense, int level, int points, int movementSpeed)
                : base(hp, attack, defense, level, points, movementSpeed)
        {
        }

        internal LaserHighTierMonster(int level)
                : base(level)
        {
        }

        public Skill[] SideSkills()
        {
            var dist = new Skill[this.SpecialSkills.Length];
            Array.Copy(this.SpecialSkills, dist, this.SpecialSkills.Length);
            return dist;
        }

        protected override void SetInitialSkills()
        {
            Skill[] s = {
                new Skill(this.Attack, "Generic attack"),
                new Skill(this.Attack * 2, "Generic side attack"),
                new Skill(this.Attack * 3, "Generic side attack 2")
            };
            this.SetSpecialSkills(s);
        }

        public string GetMonsterName()
        {
            return "Generic High Tier Monster";
        }
    }

    internal class LaserFlyingMonster : LaserHighTierMonster, IFly, IFlyingMonster
    {
        protected int FlyingSpeed;
        protected Skill[] FlyingSkills = new Skill[0];

        internal LaserFlyingMonster(int hp, int attack, int defense, int level, int points, int movementSpeed, int flyingSpeed)
            : base(hp, attack, defense, level, points, movementSpeed)
        {
            this.FlyingSpeed = flyingSpeed;
        }

        internal LaserFlyingMonster(int level)
            : base(level)
        {
            this.FlyingSpeed = level * LaserFlyingMonster.MULTIPLIERS[4];
        }

        public int GetFlySpeed()
        {
            return this.FlyingSpeed;
        }

        public string FlyAnimation()
        {
            return "The monster flaps its wings to fly";
        }

        public string Fly()
        {
            return "This object flies. " + this.FlyAnimation();
        }

        protected override void SetInitialSkills()
        {
            Skill[] s = {
                new Skill(this.Attack, "Generic attack"),
                new Skill(this.Attack * 2, "Generic side attack"),
                new Skill(this.Attack * 3, "Generic side attack 2")
            };
            this.SetSpecialSkills(s);

            Skill[] fs = {
                new Skill(this.Attack, "Generic fly attack"),
                new Skill(this.Attack * 2, "Generic side fly attack"),
                new Skill(this.Attack * 3, "Generic side fly attack 2")
            };
            this.SetFlyingSkills(fs);
        }

        protected void SetFlyingSkills(Skill[] skills)
        {
            this.FlyingSkills = skills;
        }

        public Skill[] GetFlyingSkills()
        {
            return this.FlyingSkills;
        }

        public Skill MainFlySkill()
        {
            return this.FlyingSkills[0];
        }

        public Skill[] FlySideSkills()
        {
            var dist = new Skill[FlyingSkills.Length];
            Array.Copy(this.FlyingSkills, dist, this.FlyingSkills.Length);
            return dist;
        }

        public string GetMonsterName()
        {
            return "Generic Flying Monster";
        }
    }

    internal class LaserHybridMonster : LaserFlyingMonster,IHybridMonster
    {
        protected int AscendSpeed;
        protected int DescendSpeed;

        internal LaserHybridMonster(int hp, int attack, int defense, int level, int points, int movementSpeed, int flyingSpeed, int ascendSpeed, int descendSpeed)
                : base(hp, attack, defense, level, points, movementSpeed, flyingSpeed)
        {
            this.AscendSpeed = ascendSpeed;
            this.DescendSpeed = descendSpeed;
        }

        internal LaserHybridMonster(int level)
            : base(level)
        {
            this.AscendSpeed = level * LaserHybridMonster.MULTIPLIERS[4];
        }

        public int GetAscendSpeed()
        {
            return this.AscendSpeed;
        }

        public int GetDescendSpeed()
        {
            return this.DescendSpeed;
        }

        public string GetMonsterName()
        {
            return "Generic Hybrid Monster";
        }
    }

    internal class LaserFinalBossMonster : LaserHighTierMonster, IFinalBossMonster
    {
        protected const int TOTAL_STAGES = 3;
        protected int CurrentStage = 0;

        internal LaserFinalBossMonster(int hp, int attack, int defense, int level, int points, int movementSpeed)
            : base(hp, attack, defense, level, points, movementSpeed)
        {
        }

        internal LaserFinalBossMonster(int level)
            : base(level)
        {
        }

        public string StageIncrement()
        {
            if (this.CurrentStage >= LaserFinalBossMonster.TOTAL_STAGES) return "NO MORE STAGES";
            this.CurrentStage++;
            this.Attack *= this.CurrentStage;
            this.Defense *= this.CurrentStage;
            return "BOSS MONSTER CHANGE! STAGE - " + this.CurrentStage;
        }

        public string StageDecrement()
        {
            if (this.CurrentStage <= 0) return "NO MORE STAGES";
            this.CurrentStage--;
            this.Attack /= this.CurrentStage;
            this.Defense /= this.CurrentStage;
            return "BOSS MONSTER REVERT! STAGE - " + this.CurrentStage;
        }

        public string GetMonsterName()
        {
            return "Generic Final Boss Monster";
        }
    }
}
