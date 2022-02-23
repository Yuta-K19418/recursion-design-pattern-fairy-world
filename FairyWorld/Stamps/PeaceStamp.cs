using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Stamps
{
    internal class PeaceStamp : GenericStamp
    {
        private const string TITLE = "Peace";
        private const string RENDER = "☮️";

        internal PeaceStamp(string color)
        {
            this.title = PeaceStamp.TITLE;
            this.render = PeaceStamp.RENDER;
            this.color = color;
        }

        internal PeaceStamp(IStamp stamp)
        {
            this.title = PeaceStamp.TITLE;
            this.render = PeaceStamp.RENDER;
            this.color = stamp.GetColor();
        }
        public override IStamp Clone()
        {
            return new PeaceStamp(this);
        }
    }
}
