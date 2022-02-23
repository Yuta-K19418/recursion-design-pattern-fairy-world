using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Sandwiches
{
    internal class Sandwich : FastFood
    {
        internal Sandwich(string? doughType, string? topping1, string? topping2, string? topping3, string? topping4, string? vegetable1, string? vegetable2, string? vegetable3, string? vegetable4, string? vegetable5, bool cheese, bool ketchup, bool mustard, bool mayonnaise, string? sauce)
        {
            this.doughType = doughType;
            this.topping1 = topping1;
            this.topping2 = topping2;
            this.topping3 = topping3;
            this.topping4 = topping4;
            this.vegetable1 = vegetable1;
            this.vegetable2 = vegetable2;
            this.vegetable3 = vegetable3;
            this.vegetable4 = vegetable4;
            this.vegetable5 = vegetable5;
            this.cheese = cheese;
            this.ketchup = ketchup;
            this.mustard = mustard;
            this.mayonnaise = mayonnaise;
            this.sauce = sauce;
        }

        public override string GetString()
        {
            var sandwich = new StringBuilder("This Sandwich Is " + this.doughType + " with " + this.topping1 + " ");

            if (this.topping2 != null)
            {
                sandwich.Append(this.topping2 + ", ");
            }

            if (this.topping3 != null)
            {
                sandwich.Append(this.topping3 + ", ");
            }

            if (this.vegetable1 != null)
            {
                sandwich.Append(this.vegetable1 + ", ");
            }

            if (this.vegetable2 != null)
            {
                sandwich.Append(this.vegetable2 + ", ");
            }

            if (this.vegetable3 != null)
            {
                sandwich.Append(this.vegetable3 + ", ");
            }

            if (this.vegetable4 != null)
            {
                sandwich.Append(this.vegetable4 + ", ");
            }

            if (this.cheese)
            {
                sandwich.Append("with cheese, ");
            }

            if (this.cheese && this.topping4 != null)
            {
                sandwich.Append("with" + " additional "+ this.topping4 + " , ");
            }

            if (this.ketchup)
            {
                sandwich.Append("with ketchup, ");
            }

            if (this.mustard)
            {
                sandwich.Append("with mustard, ");
            }

            if (this.mayonnaise)
            {
                sandwich.Append("with mayonnaise, ");
            }

            if (this.sauce != null)
            {
                sandwich.Append("with " + this.sauce);
            }

            return sandwich.ToString();
        }
    }
}
