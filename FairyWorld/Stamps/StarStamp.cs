using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Stamps
{
    internal class StarStamp : GenericStamp
    {
        private const string TITLE = "Star";
        private const string RENDER = "⭐";

        internal StarStamp(string color)
        {
            this.title = StarStamp.TITLE;
            this.render = StarStamp.RENDER;
            this.color = color;
        }

        internal StarStamp(IStamp stamp)
        {
            this.title = StarStamp.TITLE;
            this.render = StarStamp.RENDER;
            this.color = stamp.GetColor();
        }


        public override IStamp Clone()
        {
            return new StarStamp(this.GetColor());
        }
    }
}
