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

        String orderType;

        internal Order(Customer customer, Sandwich sandwich, String orderType)
        {
            this.customer = customer;
            this.sandwich = sandwich;
            this.orderType = orderType;
        }
        public override string ToString()
        {
            String orderInfo = "";

            orderInfo += customer.ToString() + "\n" + orderType + "\n" +
            sandwich.ToString();

            return orderInfo;

        }
    }
}
