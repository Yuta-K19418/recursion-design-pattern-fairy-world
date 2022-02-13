using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Mosters
{
    internal interface IMonster
    {
        public int GetHP();
        public int GetAttack();
        public int GetDefense();
        public int GetLevel();
        public int GetPoints();
        public int GetMovementSpeed();
        public string GetMonsterName();
        public string GetAppearance();
        public string Kill();
        public Skill[] GetSpecialSkill();
    }
}
