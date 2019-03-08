using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrders
{
    class Check : Payment
    {
        private String name;
        private String bank;
        private Boolean authorized = false;

        public Check(String name, String bank, double amount)
        {
            this.name = name;
            this.bank = bank;
            base.amount = amount;
        }

        public void Authorize()
        {
            this.authorized = true;
        }

        public String GetBank()
        {
            return this.bank;
        }

        public String getName()
        {
            return this.name;
        }

        public bool IsAuthorized()
        {
            return this.authorized;
        }
    }
}
