using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Themes
{
    internal class FairyWorldThemeFactory : IFairyWorldThemeFactory
    {
        public ISpring CreateSpring()
        {
            return new Spring();
        }

        public ISummer CreateSummer()
        {
            return new Summer();
        }

        public IAutumn CreateAutumn()
        {
            return new Autumn();
        }

        public IWinter CreateWinter()
        {
            return new Winter();
        }

        public IHalloween CreateHalloween()
        {
            return new Halloween();
        }

        public IValentine CreateValentine()
        {
            return new Valentine();
        }
    }
}
