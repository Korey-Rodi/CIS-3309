using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwhichBuilder
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
            get { return name; } set { name = value; }
        }

        public String Description
        {
            get { return  description; } set { description = value; }
        }
        public String Size
        {
            get { return size; } set { size = value}
        }
        internal Sandwich()
        {
            name = "";
            description = "";
            size = "";
            sauces = new List<String>();
            meats = new List<String>();
            cheese = new List<String>();
            toppings = new List<String>();
            premToppings = new List<String>();

        }
    }
}
