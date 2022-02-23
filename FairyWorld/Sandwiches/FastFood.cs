using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Sandwiches
{
    internal abstract class FastFood
    {
        protected private string? doughType;
        protected private string? topping1;
        protected private string? topping2;
        protected private string? topping3;
        protected private string? topping4;
        protected private string? vegetable1;
        protected private string? vegetable2;
        protected private string? vegetable3;
        protected private string? vegetable4;
        protected private string? vegetable5;
        protected private double sizeCm;
        protected private bool cheese;
        protected private bool ketchup;
        protected private bool mustard;
        protected private bool mayonnaise;
        protected private string? sauce;

        public abstract string GetString();
    }
}
