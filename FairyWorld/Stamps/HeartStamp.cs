using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Stamps
{
    internal class HeartStamp : GenericStamp
    {
        private const string TITLE = "Heart";
        private const string RENDER = "💖";

        internal HeartStamp(string color)
        {
            this.title = HeartStamp.TITLE;
            this.render = HeartStamp.RENDER;
            this.color = color;
        }

        internal HeartStamp(IStamp stamp)
        {
            this.title = HeartStamp.TITLE;
            this.render = HeartStamp.RENDER;
            this.color = stamp.GetColor();
        }

        public override IStamp Clone()
        {
            return new HeartStamp(this);
        }
    }
}
