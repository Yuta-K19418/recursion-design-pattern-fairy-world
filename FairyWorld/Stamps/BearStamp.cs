using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Stamps
{
    internal class BearStamp : GenericStamp
    {
        private const string TITLE = "Bear";
        private const string RENDER = "🐻";

        internal BearStamp(string color)
        {
            this.title = BearStamp.TITLE;
            this.render = BearStamp.RENDER;
            this.color = color;
        }

        internal BearStamp(IStamp stamp)
        {
            this.title = BearStamp.TITLE;
            this.render = BearStamp.RENDER;
            this.color = stamp.GetColor();
        }


        public override IStamp Clone()
        {
            return new BearStamp(this.GetColor());
        }
    }
}
