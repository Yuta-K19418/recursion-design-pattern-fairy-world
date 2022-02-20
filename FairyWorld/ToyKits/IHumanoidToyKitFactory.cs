using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.ToyKits
{
    internal interface IHumanoidToyKitFactory
    {
        public IRobot CreateRobot();

        public IVampire CreateVampire();

        public IWerewolf CreateWerewolf();

        public ITransformer CreateTransformer();

        public IAlien CreateAlien();
    }
}
