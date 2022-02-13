using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld
{
    internal class Skill
    {
        protected int Damage;
        protected string Description;

        internal Skill(int damage, string description)
        {
            this.Damage = damage;
            this.Description = description;
        }

        public int GetDamage()
        {
            return this.Damage;
        }

        public string GetDescription()
        {
            return this.Description;
        }
    }
}
