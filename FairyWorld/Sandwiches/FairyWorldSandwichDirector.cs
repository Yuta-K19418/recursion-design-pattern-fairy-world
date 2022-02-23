using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyWorld.Sandwiches
{
    internal class FairyWorldSandwichDirector
    {
        internal enum SandwichMenu
        {
            CHICKEN_AND_BACON,
            STEAK_AND_CHEESE,
            SPICY_ITALIAN,
            TUNA_AND_EGG,
        }

        internal enum SandwichSize
        {
            FOOTLONG,
            HALF_FOOTLONG,
        }

        internal static Builder ChickenAndBacon(Builder builder)
        {
            builder.AddDoughType("Italian")
                    .AddTopping1("Chicken")
                    .AddTopping2("Bacon")
                    .AddTopping4("Cheeze")
                    .AddSauce("Ranch")
                    .AddVegetable1("Lettuce")
                    .AddVegetable2("Red Onions")
                    .AddVegetable3("Tomato")
                    .AddCheese();

            return builder;
        }

        internal static Builder SteakAndCheese(Builder builder)
        {
            builder.AddDoughType("Wheat")
                    .AddTopping1("Steak")
                    .AddTopping2("Steak")
                    .AddTopping4("Cheeze")
                    .AddVegetable1("Green Peppers")
                    .AddVegetable2("Red Onions")
                    .AddCheese();

            return builder;
        }

        internal static Builder SpicyItalian(Builder builder)
        {
            builder.AddDoughType("Wheat")
                    .AddTopping1("Pepperoni")
                    .AddTopping2("Salami")
                    .AddTopping4("Cheeze")
                    .AddVegetable1("Lettuce")
                    .AddVegetable2("Red Onions")
                    .AddVegetable3("Tomato")
                    .AddVegetable4("Cucumbers")
                    .AddVegetable5("Jalapeno")
                    .AddMayo();

            return builder;
        }

        internal static Builder TunaAndEgg(Builder builder)
        {
            builder.AddDoughType("Italian Herbs")
                    .AddTopping1("Tuna")
                    .AddTopping2("Eggs")
                    .AddTopping4("Cheeze")
                    .AddVegetable1("Lettuce")
                    .AddVegetable2("Red Onions")
                    .AddMayo();

            return builder;
        }
    }
}
