using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Stamps
{
    internal class TreeStamp : GenericStamp
    {
        private const string TITLE = "Tree";
        private const string RENDER = "🌲";

        internal TreeStamp(string color)
        {
            this.title = TreeStamp.TITLE;
            this.render = TreeStamp.RENDER;
            this.color = color;
        }

        internal TreeStamp(IStamp stamp)
        {
            this.title = TreeStamp.TITLE;
            this.render = TreeStamp.RENDER;
            this.color = stamp.GetColor();
        }

        public override IStamp Clone()
        {
            return new TreeStamp(this);
        }
    }
}
