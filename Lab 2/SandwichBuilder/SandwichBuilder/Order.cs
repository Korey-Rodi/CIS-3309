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
        Decimal tip;

        internal Order(Customer customer, Sandwich sandwich, String orderType, Decimal tip)
        {
            this.customer = customer;
            this.sandwich = sandwich;
            this.orderType = orderType;
            this.tip = tip;
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
