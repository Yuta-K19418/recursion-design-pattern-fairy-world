using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Stamps
{
    internal interface IStamp : IPrototype<IStamp>
    {
        public string GetTitle();
        public string GetRender();
        public string GetColor();

        public string GetString();
    }
}
