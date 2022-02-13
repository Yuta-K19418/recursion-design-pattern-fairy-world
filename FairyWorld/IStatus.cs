using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld
{
    internal interface IStatus
    {
        public string GetHappiness();

        public void SetHappiness();

        public string GetEnergy();

        public void SetEnergy();

        public string GetNausea();

        public void SetNausea();

        public string GetFrightful();

        public void SetFrightful();
    }
}
