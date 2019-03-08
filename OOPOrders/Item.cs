using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrders
{
    class Item
    {
        private double shippingweight;        // The shipping weight in kilograms

        private String description;

        private Boolean instock;

        private double price;

        public Item(String description, double shippingweight, double price, bool instock = false)
        {
            this.description = description;
            this.shippingweight = shippingweight;
            this.price = price;
            this.instock = instock;
        }

        public String GetDescription()
        {
            return this.description;
        }

        public double GetPriceForQuantity(int quantity)
        {
            return this.price * quantity;
        }

        public double GetShippingWeight()
        {
            return this.shippingweight;
        }

        public double GetTax()
        {
            return Math.Round(this.price / 5, 2);
        }

        public void InStock(Boolean instock)
        {
            this.instock = instock;
        }

        public Boolean IsInStock()
        {
            return this.instock;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + this.description;
        }
    }
}
