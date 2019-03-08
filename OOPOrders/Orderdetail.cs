using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrders
{
    class Orderdetail
    {
        private int quantity;
        private String taxStatus;
        private Item item;

        public Orderdetail(Item item, int quantity, String taxStatus = "VAT")
        {
            this.item = item;
            this.quantity = quantity;
            this.taxStatus = taxStatus;
        }

        public double CalcSubtotal()
        {
            return this.item.GetPriceForQuantity(this.quantity);
        }

        public double CalcTax()
        {
            return this.quantity * this.item.GetTax();
        }

        public double CalcWeight()
        {
            return this.quantity * this.item.GetShippingWeight();
        }

        public Item GetItem()
        {
            return this.item;
        }

        public int GetQuantity()
        {
            return this.quantity;
        }

        public String GetTaxStatus()
        {
            return this.taxStatus;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + this.quantity + " × "+this.item.GetDescription();
        }
    }
}
