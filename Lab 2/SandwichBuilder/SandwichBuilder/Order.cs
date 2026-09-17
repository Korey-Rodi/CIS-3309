using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichBuilder
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

            orderInfo += customer.ToString() + "\n" + sandwich.ToString();

            return orderInfo;

        }
    }
}
