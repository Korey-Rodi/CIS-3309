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
        Decimal subtotal;

        internal Order(Customer customer, Sandwich sandwich, String orderType, Decimal tip,
        Decimal subtotal)
        {
            this.customer = customer;
            this.sandwich = sandwich;
            this.orderType = orderType;
            this.tip = tip;
            this.subtotal = subtotal;
        }
        public override string ToString()
        {
            String orderInfo = "";

            orderInfo += customer.ToString() + "\n" + orderType + "\n" +
            sandwich.ToString() + "\n" + subtotal.ToString("C") + "\n"
            + tip.ToString("C");

            return orderInfo;

        }
    }
}
