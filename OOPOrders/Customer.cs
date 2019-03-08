using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrders
{
    class Customer
    {
        private String name;
        private String address;

        public Customer(String name, String address)
        {
            this.name = name;
            this.address = address;
        }

        public String getAddress()
        {
            return this.address;
        }

        public String getName()
        {
            return this.name;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + this.name;
        }
    }
}
