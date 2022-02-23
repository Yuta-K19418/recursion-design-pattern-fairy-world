using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Stamps
{
    internal static class StampPrototypeFactory
    {
        private static Dictionary<int, IStamp> stampDic;
        private const string DEFAULT_COLOR = "#e74c3c";

        static StampPrototypeFactory()
        {
            StampPrototypeFactory.stampDic = new Dictionary<int, IStamp>();
            StampPrototypeFactory.stampDic.Add(0, new GenericStamp(StampPrototypeFactory.DEFAULT_COLOR));
            StampPrototypeFactory.stampDic.Add(1, new StarStamp(StampPrototypeFactory.DEFAULT_COLOR));
            StampPrototypeFactory.stampDic.Add(2, new HeartStamp(StampPrototypeFactory.DEFAULT_COLOR));
            StampPrototypeFactory.stampDic.Add(3, new PeaceStamp(StampPrototypeFactory.DEFAULT_COLOR));
        }

        internal static void UpdatePrototype(int key, IStamp stamp)
        {
            if (StampPrototypeFactory.stampDic.ContainsKey(key))
            {
                StampPrototypeFactory.stampDic[key] = stamp;
            }
            else
            {
                StampPrototypeFactory.stampDic.Add(key, stamp);
            }
        }

        internal static IStamp? GetStamp(int key)
        {
            if (StampPrototypeFactory.stampDic.ContainsKey(key))
            {
                return StampPrototypeFactory.stampDic[key].Clone();
            }
            
            return null;
        }
    }
}
