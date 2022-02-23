using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Sandwiches
{
    internal class Builder
    {
        private const string DEFAULT_DOUGH = "Wheat";
        private const string DEFAULT_TOPPING1 = "Ham";

        private string? doughType;
        private string? topping1;
        private string? topping2;
        private string? topping3;
        private string? topping4;
        private string? vegetable1;
        private string? vegetable2;
        private string? vegetable3;
        private string? vegetable4;
        private string? vegetable5;

        private double sizeCm;
        private bool cheese;
        private bool ketchup;
        private bool mustard;
        private bool mayonnaise;
        private string? sauce;
        private string fastFood;

        internal Builder(string fastFood)
        {
            this.fastFood = fastFood;
            this.Reset();
        }

        internal Builder AddDoughType(string doughType)
        {
            this.doughType = doughType;
            return this;
        }

        internal Builder AddTopping1(string topping)
        {
            this.topping1 = topping;
            return this;
        }

        internal Builder AddTopping2(string topping)
        {
            this.topping2 = topping;
            return this;
        }

        internal Builder AddTopping3(string topping)
        {
            this.topping3 = topping;
            return this;
        }
        
        internal Builder AddTopping4(string topping)
        {
            this.topping4 = topping;
            return this;
        }

        internal Builder AddVegetable1(string vegetable)
        {
            this.vegetable1 = vegetable;
            return this;
        }

        internal Builder AddVegetable2(string vegetable)
        {
            this.vegetable2 = vegetable;
            return this;
        }

        internal Builder AddVegetable3(string vegetable)
        {
            this.vegetable3 = vegetable;
            return this;
        }

        internal Builder AddVegetable4(string vegetable)
        {
            this.vegetable4 = vegetable;
            return this;
        }

        internal Builder AddVegetable5(string vegetable)
        {
            this.vegetable5 = vegetable;
            return this;
        }

        internal Builder AddCheese()
        {
            this.cheese = true;
            return this;
        }

        internal Builder NoCheese()
        {
            this.cheese = false;
            return this;
        }

        internal Builder AddKetchup()
        {
            this.ketchup = true;
            return this;
        }

        internal Builder NoKetchup()
        {
            this.ketchup = false;
            return this;
        }

        internal Builder AddMustard()
        {
            this.mustard = true;
            return this;
        }

        internal Builder NoMustard()
        {
            this.mustard = false;
            return this;
        }

        internal Builder AddMayo()
        {
            this.mayonnaise = true;
            return this;
        }

        internal Builder NoMayo()
        {
            this.mayonnaise = false;
            return this;
        }

        internal Builder AddSauce(string sauce)
        {
            this.sauce = sauce;
            return this;
        }

        internal Builder SetSize(double size)
        {
            this.sizeCm = size;
            return this;
        }


        public FastFood Build()
        {
            FastFood ff;
            switch (this.fastFood)
            {
                case "sandwich":
                    ff = new Sandwich(
                        doughType: this.doughType,
                        topping1: this.topping1,
                        topping2: this.topping2,
                        topping3: this.topping3,
                        topping4: this.topping4,
                        vegetable1: this.vegetable1,
                        vegetable2: this.vegetable2,
                        vegetable3: this.vegetable3,
                        vegetable4: this.vegetable4,
                        vegetable5: this.vegetable5,
                        cheese: this.cheese,
                        ketchup: this.ketchup,
                        mustard: this.mustard,
                        mayonnaise: this.mayonnaise,
                        sauce: this.sauce
                    );
                    break;

                case "hamburger":
                    ff = new Hamburger(
                        doughType: this.doughType,
                        topping1: this.topping1,
                        topping2: this.topping2,
                        topping3: this.topping3,
                        topping4: this.topping4,
                        vegetable1: this.vegetable1,
                        vegetable2: this.vegetable2,
                        vegetable3: this.vegetable3,
                        vegetable4: this.vegetable4,
                        vegetable5: this.vegetable5,
                        cheese: this.cheese,
                        ketchup: this.ketchup,
                        mustard: this.mustard,
                        mayonnaise: this.mayonnaise,
                        sauce: this.sauce
                    );
                    break;

                default:
                    throw new NotImplementedException();
            }

            this.Reset();
            return ff;
        }


        internal Builder Reset()
        {
            this.doughType = DEFAULT_DOUGH;
            this.topping1 = DEFAULT_TOPPING1;
            this.topping2 = null;
            this.topping3 = null;
            this.topping4 = null;
            this.vegetable1 = null;
            this.vegetable2 = null;
            this.vegetable3 = null;
            this.vegetable4 = null;
            this.vegetable5 = null;

            this.cheese = false;
            this.ketchup = false;
            this.mustard = false;
            this.mayonnaise = false;
            this.sauce = null;
            return this;
        }

    }
}
