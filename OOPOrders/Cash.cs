using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrders
{
    class Cash : Payment
    {
        private double cashTendered;

        public Cash(float cashTendered)
        {
            this.cashTendered = cashTendered;

            // We also need to update the payment amount in the superclass
            base.amount = cashTendered;
        }

        public double GetCashTendered()
        {
            return this.cashTendered;
        }
    }
}
