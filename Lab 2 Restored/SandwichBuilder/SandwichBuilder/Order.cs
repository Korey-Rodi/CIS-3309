using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace SandwhichBuilder
{
    internal class Order
    {
        Customer customer;
        Sandwich sandwich;
    internal Order(Customer customer, Sandwich sandwich)
        {
            this.customer = customer;
            this.sandwich = sandwich;
        }

        public override string ToString()
        {
            String orderInfo = "";

            orderInfo += customer.ToString() + "\n" + sandwich.ToString() + "\n";
        }
        //public static decimal CalculatePrice()
        //{
            
        //}
    }
}