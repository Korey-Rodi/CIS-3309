using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichBuilder
{
    internal static class Pricing
    {
        // Size 5 (small, medium, large, extra-large, and party size)
        // Bread 6 (White, Rye, Long roll, Flatbread, Wheat, Whole Grain)
        // Sauces 8 (Hot sauce, Mayo, Oil, Vinegar, Mustard, Ranch, Ketchup, Chipotle)
        // Meats 10 (Turkey, Ham, Roast Beef, Chicken, Salami, Pepperoni, Bacon, Pastrami, Capicola, Prosciutto)
        // Cheese 5 (Cheddar, Pepper Jack, Buffalo Cheese, Gouda, Swiss)
        // Toppings 10 (Lettuce, Tomato, Onion, Pickles, Banana Peppers, Jalapenos, Olives, Cucumbers, Avocado, Spinach)
        // Premium Toppings 10 (Extra Lettuce, Extra Tomato, Extra Onion, Extra Pickles,

        public static Decimal CostCalculator(Dictionary<String, Decimal> Cost, String item)
        {
            if (Cost.TryGetValue(item, out Decimal result))
            {
                return result;
            }
            else
            {
                return 0.0m;
            }
        }
        internal static Dictionary<String, Decimal> SizePricing = new Dictionary<String, Decimal>
    {
            {"Small", 5.00m },
            {"Medium", 6.50m },
            {"Large", 8.00m },
            {"Extra-Large", 9.50m },
            {"Party Size", 25.00m }
    };
        internal static Dictionary<String, Decimal> breadPricing = new Dictionary<String, Decimal>
    {
            {"White", 1.00m},
            {"Rye",1.00m},
            {"Long Roll",1.50m },
            {"Flat bread",.50m },
            {"Wheat",2.00m},
            {"Whole Grain",5.00m }

    };
        internal static Dictionary<String, Decimal> saucePricing = new Dictionary<string, decimal>
        {
            {"Hot Sauce",.25m},
            {"Mayo",.10m },
            {"Oil",.10m },
            {"Vinegar", .10m},
            {"Mustard", .10m},
            {"Ranch", .50m},
            {"Ketchup",.10m},
            {"Chipotle", .50m}
        };

        internal static Dictionary<String, Decimal> meatPricing = new Dictionary<string, decimal>
        {
            {"Turkey", 2.00m},
            {"Ham", 2.00m},
            {"Roast Beef", 3.50m},
            {"Chicken", 3.00m},
            {"Salami",1.00m},
            {"Pepperoni",1.00m},
            {"Bacon",1.25m},
            {"Pastrami",3.00m},
            {"Capicola", 3.25m},
            {"Prosciutto",3.75m}
        };

// Cheese 5 (Cheddar, Pepper Jack, Buffalo Cheese, Gouda, Swiss)
        internal static Dictionary<String, Decimal> cheesePricing = new Dictionary<string, decimal>
        {
            {"Cheddar",.25m },
            {"Pepper Jack", .25m},
            {"Buffalo Cheese", .50m},
            {"Gouda", .75m},
            {"Swiss", .50m}

        };

         // Toppings 10 (Lettuce, Tomato, Onion, Pickles, Banana Peppers, Jalapenos, Olives, Cucumbers, Avocado, Spinach)
         internal static Dictionary<String, Decimal> toppingsPricing = new Dictionary<string, decimal>
         {
             {"Lettuce", .10m},
             {"Tomato", .10m},
             {"Onion", .05m},
             {"Pickles", .20m},
             {"Peppers" , .25m},
             {"Jalapenos" , .35m},
             {"Olives", .10m},
             {"Cucumbers", .10m},
             {"Avocado", 1.00m},
             {"Spinach", .10m}
         };

         internal static Dictionary<String, Decimal> premToppingsPricing = new Dictionary<string, decimal>
         {
             {"Extra Lettuce", .20m},
             {"Extra Tomato", .20m},
             {"Extra Onion", .10m},
             {"Extra Pickles", .40m},
             {"Extra Peppers" , .50m},
             {"Extra Jalapenos" , .70m},
             {"Extra Olives", .20m},
             {"Extra Cucumbers", .20m},
             {"Extra Avocado", 2.00m},
             {"Extra Spinach", .20m}
         };
    }
}
