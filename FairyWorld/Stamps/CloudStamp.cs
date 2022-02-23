using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Stamps
{
    internal class CloudStamp : GenericStamp
    {
        private const string TITLE = "Cloud";
        private const string RENDER = "☁";

        internal CloudStamp(string color)
        {
            this.title = CloudStamp.TITLE;
            this.render = CloudStamp.RENDER;
            this.color = color;
        }

        internal CloudStamp(IStamp stamp)
        {
            this.title = CloudStamp.TITLE;
            this.render = CloudStamp.RENDER;
            this.color = stamp.GetColor();
        }


        public override IStamp Clone()
        {
            return new CloudStamp(this.GetColor());
        }
    }
}
