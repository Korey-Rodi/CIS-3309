using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace SandwichBuilder
{
    internal class Customer
    {
        String name;
        String address;
        String phoneNumber;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        public String PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        internal Customer(String name, String address, String phoneNumber)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            String customerInfo = "";

            customerInfo += name + "\n";
            customerInfo += address + "\n";
            customerInfo += phoneNumber + "\n";

            return customerInfo;

        }
    }
}