using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrders
{
    abstract class Payment
    {
        protected double amount;

        public double GetAmount()
        {
            return this.amount;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + this.amount;
        }
    }
}
