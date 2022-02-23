using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Stamps
{
    internal interface IPrototype<T>
    {
        internal T Clone();
    }
}
