using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichBuilder
{
    internal class Sandwich
    {
        String name;

        String description;
        String size;
        String bread;
        List<String> sauces;
        List<String> meats;
        List<String> cheese;
        List<String> toppings;
        List<String> premToppings;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String Size
        {
            get { return size; }
            set { size = value; }
        }

        public String Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        public List<String> Sauces
        {
            get { return sauces; }
            set { sauces = value; }
        }

        public List<String> Meats
        {
            get { return meats; }
            set { meats = value; }
        }

        public List<String> Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        public List<String> Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

        public List<String> PremToppings 
        {
            get { return premToppings; }
            set { premToppings = value; }
        }

        internal Sandwich(String name, String description,
            String size, String bread, List<String> sauces, List<String> meats, List<String> cheese,
            List<String> toppings, List<String> premToppings)
        {
            this.name = name;
            //this.imagePath = imagePath;
            this.description = description;
            this.size = size;
            this.bread = bread;
            this.sauces = sauces;
            this.meats = meats;
            this.cheese = cheese;
            this.toppings = toppings;
            this.premToppings = premToppings;

            // Size 5 (small, medium, large, extra-large, and party size)
            // Bread 6 (White, Rye, Long roll, Flatbread, Wheat, Whole Grain)
            // Sauces 8 (Hot sauce, Mayo, Oil, Vinegar, Mustard, Ranch, Ketchup, Chipotle)
            // Meats 10 (Turkey, Ham, Roast Beef, Chicken, Salami, Pepperoni, Bacon, Pastrami, Capicola, Prosciutto)
            // Cheese 5 (Cheddar, Pepper Jack, Buffalo Cheese, Gouda, Swiss)
            // Toppings 10 (Lettuce, Tomato, Onion, Pickles, Banana Peppers, Jalapenos, Olives, Cucumbers, Avocado, Spinach)
            // Premium Toppings 10 (Extra Lettuce, Extra Tomato, Extra Onion, Extra Pickles, Extra Banana Peppers, Extra Jalapenos, Extra Olives, Extra Cucumbers, Extra Avocado, Extra Spinach)
        }

        public override String ToString()
        {
            String sandwichInfo = "";

            sandwichInfo += "Name: " + name + "\n";
            sandwichInfo += "Desc: " + description + "\n";
            sandwichInfo += "Size: " + size + "\n";
            sandwichInfo += "Bread: " + bread + "\n";

            // https://stackoverflow.com/questions/759133/how-to-display-list-items-on-console-window-in-c-sharp
            sandwichInfo += "Sauces: " + String.Join(", ", sauces) + "\n";
            sandwichInfo += "Meats: " + String.Join(", ", meats) + "\n";
            sandwichInfo += "Cheese: " + String.Join(", ", cheese) + "\n";
            sandwichInfo += "Toppings: " + String.Join(", ", toppings) + "\n";
            sandwichInfo += "Extra Toppings: " + String.Join(", ", premToppings);

            return sandwichInfo;
        }
        public decimal GetTotal()
        {
            Decimal subtotal = 0.0m;

            subtotal += Pricing.CostCalculator(Pricing.SizePricing, size);
            subtotal += Pricing.CostCalculator(Pricing.breadPricing, bread);


            if (sauces != null)
            {
                foreach (string sauce in sauces)
                {
                    subtotal += Pricing.CostCalculator(Pricing.saucePricing, sauce);
                }
            }

            if (meats != null)
            {
                foreach (string meat in meats)
                {
                    subtotal += Pricing.CostCalculator(Pricing.meatPricing, meat);
                }
            }

            if (cheese != null)
            {
                foreach (string cheese in cheese)
                {
                    subtotal += Pricing.CostCalculator(Pricing.cheesePricing, cheese);
                }
            }

            if (toppings != null)
            {
                foreach (string toppings in toppings)
                {
                    subtotal += Pricing.CostCalculator(Pricing.toppingsPricing, toppings);
                }
            }

            if (premToppings != null)
            {
                foreach (string premToppings in premToppings)
                {
                    subtotal += Pricing.CostCalculator(Pricing.premToppingsPricing, premToppings);
                }
            }

            return subtotal;
        }

        public static class PreMadeSandwiches
        {
            public static List<Sandwich> preMade = new List<Sandwich>();

            static PreMadeSandwiches()
            {
                preMade.Add(new Sandwich("Small love Turkey", "Turkey sandwich made with love",
                    "Small", "White",
                    new List<String> {"Mayo", "Ketchup"},
                    new List<String> {"Turkey"},
                    new List<String> {"Cheddar"},
                    new List<String> {"Lettuce"},
                    new List<String> {"Extra Avocado"}));

                preMade.Add(new Sandwich("Large hateful Turkey","Large Turkey sandwich made with hate",
                    "Large", "Rye",
                    new List<String> {"Hot Sauce"},
                    new List<String> {"Turkey"},
                    new List<String> {"Buffalo Cheese"},
                    new List<String> {"Lettuce"},
                    new List<String> {"Extra Lettuce"}));

                preMade.Add(new Sandwich("Party hateful Turkey", "Family size Turkey sandwich made with hate",
                    "Party Size", "Long Roll",
                    new List<String> {"Hot Sauce"},
                    new List<String> {"Turkey"},
                    new List<String> {"Buffalo Cheese"},
                    new List<String> {"Lettuce"},
                    new List<String> {"Extra Avocado"}));
            }
        }
    }
}