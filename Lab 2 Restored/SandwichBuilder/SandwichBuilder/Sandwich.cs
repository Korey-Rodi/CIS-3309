using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using Microsoft.VisualBasic;

namespace SandwhichBuilder
{
    internal class Sandwich
    {
        String name;

        String? imagePath; // This needs to be nullable bc not all will have an image
        String description;
        String size;
        String bread;
        List<String> sauces;
        List<String> meats;
        List<String> cheese;
        List<String>? toppings;
        List<String>? premToppings;

        public String Name
        {
            get { return name; } set { name = value; }
        }
        public String? ImagePath //This needs to be nullable
        {
            get { return imagePath; } set {imagePath = value;} 
        }

        public String Description
        {
            get { return  description; } set { description = value; }
        }
        public String Size
        {
            get { return size; } set { size = value;}
        }
        public String Bread
        {
            get { return bread; } set { bread = value; }
        }
        public List<String> sauces
        {
            get { return sauces; } set {sauces = value; }
        }
        public List<String> meats
        {
            get { return meats;} set {meats = value;}
        }
        public List<String> Cheese
        {
            get { return cheese; } set {cheese = value; }
        }
        public List<String>? Toppings
        {
            get { return toppings; } set {toppings = value; }
        }
        public List<String>? PremToppings // This needs to be nullable since its optional
        {
            get { return premToppings; } set {premToppings = value; }
        }
        internal Sandwich(String name, String? imagePath, String description,
        String size,String bread,List<String> sauces,List<String> meats,List<String> cheese,
        List<String>? toppings,List<String>? premToppings)
        {
            this.name = name;
            this.imagePath = imagePath;
            this.description = description;
            this.size = size;
            this.bread = bread;
            this.sauces = sauces;
            this.meats = meats;
            this.cheese = cheese;
            this.toppings = toppings;
            this.premToppings = premToppings;

        }
        public override String ToString()
        {
            String sandwichInfo = "";

            sandwichInfo += name + "\n";
            sandwichInfo += description + "\n";
            sandwichInfo += size + "\n";
            sandwichInfo += bread + "\n";

            // https://stackoverflow.com/questions/759133/how-to-display-list-items-on-console-window-in-c-sharp
            sandwichInfo += String.Join(", ", sauces) + "\n";
            sandwichInfo += String.Join(", ", cheese) + "\n";
            sandwichInfo += String.Join(", ", toppings ?? []) + "\n";
            sandwichInfo += String.Join(", ", premToppings ?? []);

    return sandwichInfo;
        }
    public static class preMadeSandwiches
        {
            public static List<Sandwich> preMade = new List<Sandwich>();
            
            static preMadeSandwiches (){
                preMade.Add(new Sandwich("Small love Turkey", null, "Turkey sandwich made with love",
                "Small", "White", ["Mayo","Ketchup"],["Turkey"],["Cheddar"],["Lettuce"],["Avocado"]));

                preMade.Add(new Sandwich("Large hateful Turkey", null, "Large Turkey sandwich made with hate",
                "Large", "Rye", ["Hot Sauce"],["Turkey"],["Buffalo Cheese"],["Lettuce"],null));

                preMade.Add(new Sandwich("Family hateful Turkey", null, "Family size Turkey sandwich made with hate",
                "Family Size", "Long Roll", ["Hot Sauce"],["Turkey"],["Buffalo Cheese"],["Lettuce"],null));
            }
            
        }
    }
}
