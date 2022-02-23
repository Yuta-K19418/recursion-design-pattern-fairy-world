using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Themes
{
    internal interface IFairyWorldThemeFactory
    {
        public ISpring CreateSpring();

        public ISummer CreateSummer();

        public IAutumn CreateAutumn();

        public IWinter CreateWinter();

        public IHalloween CreateHalloween();

        public IValentine CreateValentine();
    }
}
