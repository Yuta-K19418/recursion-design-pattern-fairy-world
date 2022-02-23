using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Stamps
{
    internal class VampireTeethStamp : GenericStamp
    {
        private const string TITLE = "VampireTeeth";
        private const string RENDER = "💀";

        internal VampireTeethStamp(string color)
        {
            this.title = VampireTeethStamp.TITLE;
            this.render = VampireTeethStamp.RENDER;
            this.color = color;
        }

        internal VampireTeethStamp(IStamp stamp)
        {
            this.title = VampireTeethStamp.TITLE;
            this.render = VampireTeethStamp.RENDER;
            this.color = stamp.GetColor();
        }


        public override IStamp Clone()
        {
            return new VampireTeethStamp(this.GetColor());
        }
    }
}
