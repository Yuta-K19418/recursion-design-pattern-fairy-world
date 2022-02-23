using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Stamps
{
    internal class RainbowStamp : GenericStamp
    {
        private const string TITLE = "Rainbow";
        private const string RENDER = "🌈";

        internal RainbowStamp(string color)
        {
            this.title = RainbowStamp.TITLE;
            this.render = RainbowStamp.RENDER;
            this.color = color;
        }

        internal RainbowStamp(IStamp stamp)
        {
            this.title = RainbowStamp.TITLE;
            this.render = RainbowStamp.RENDER;
            this.color = stamp.GetColor();
        }


        public override IStamp Clone()
        {
            return new RainbowStamp(this);
        }
    }
}
