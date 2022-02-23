using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Stamps
{
    internal class SkullStamp : GenericStamp
    {
        private const string TITLE = "Skull";
        private const string RENDER = "💀";

        internal SkullStamp(string color)
        {
            this.title = SkullStamp.TITLE;
            this.render = SkullStamp.RENDER;
            this.color = color;
        }

        internal SkullStamp(IStamp stamp)
        {
            this.title = SkullStamp.TITLE;
            this.render = SkullStamp.RENDER;
            this.color = stamp.GetColor();
        }


        public override IStamp Clone()
        {
            return new SkullStamp(this.GetColor());
        }
    }
}
