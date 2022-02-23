using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Themes
{
    internal class Mascot
    {
        internal string Name;

        internal double HeightCm;

        internal double WidthCm;

        internal string Appearance;

        internal Person Person;

        internal Mascot(string name, double heightCm, double widthCm, string appearance, Person person)
        {
            this.Name = name;
            this.HeightCm = heightCm;
            this.WidthCm = widthCm;
            this.Appearance = appearance;
            this.Person = person;
        }
    }
}
