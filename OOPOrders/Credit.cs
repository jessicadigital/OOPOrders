using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrders
{
    class Credit : Payment
    {
        private String number;
        private String type;
        private DateTime expDate;
        private Boolean authorized = false;

        public Credit(String number, String type, DateTime expDate, double amount)
        {
            this.number = number;
            this.type = type;
            this.expDate = expDate;
            base.amount = amount;
        }

        public void Authorize()
        {
            this.authorized = true;
        }

        public bool IsAuthorized()
        {
            return this.authorized;
        }
    }
}
