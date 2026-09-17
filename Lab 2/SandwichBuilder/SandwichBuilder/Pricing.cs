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
        internal static Dictionary<String, Decimal> SizePricing = new Dictionary<String, Decimal>
    {
            { "Small", 5.00m },
            { "Medium", 6.50m },
            { "Large", 8.00m },
            { "Extra-Large", 9.50m },
            { "Party Size", 25.00m }
    };
        internal static Dictionary<String, Decimal> breadPricing = new Dictionary<String, Decimal>
    {
            {"White", 1.00m},
            {"Rye",1.00m},
            {"Long Roll",1.50m }
            // Add rest

    };

    }
}
