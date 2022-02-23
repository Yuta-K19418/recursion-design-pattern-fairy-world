using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Stamps
{
    internal class HorseStamp : GenericStamp
    {
        private const string TITLE = "Horse";
        private const string RENDER = "🐴";

        internal HorseStamp(string color)
        {
            this.title = HorseStamp.TITLE;
            this.render = HorseStamp.RENDER;
            this.color = color;
        }

        internal HorseStamp(IStamp stamp)
        {
            this.title = HorseStamp.TITLE;
            this.render = HorseStamp.RENDER;
            this.color = stamp.GetColor();
        }


        public override IStamp Clone()
        {
            return new HorseStamp(this.GetColor());
        }
    }
}
