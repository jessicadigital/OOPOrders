using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrders
{
    class Order
    {
        private DateTime date;
        private String status;
        private List<Orderdetail> orderdetails;
        private List<Payment> payments;
        private Customer customer;

        // Creates a new order
        public Order(Customer customer)
        {
            this.date = DateTime.Now;
            this.status = "New";
            this.orderdetails = new List<Orderdetail>();
            this.payments = new List<Payment>();

            this.customer = customer;
        }

        public void AddOrderDetail(Orderdetail orderdetail)
        {
            this.orderdetails.Add(orderdetail);
        }

        public void AddPayment(Payment p)
        {
            this.payments.Add(p);
        }

        public double CalcSubTotal() {
            double subtotal = 0;
            foreach (Orderdetail orderdetail in this.orderdetails)
            {
                subtotal += orderdetail.CalcSubtotal();
            }
            return subtotal;
        }

        public double CalcTax()
        {
            double tax = 0;
            foreach (Orderdetail orderdetail in this.orderdetails)
            {
                tax += orderdetail.CalcTax();
            }
            return tax;
        }

        public double CalcWeight()
        {
            double weight = 0;
            for (int i = 0; i < this.orderdetails.Count; i++)
            {
                weight += this.orderdetails[i].CalcWeight();
            }
            return weight;
        }

        public Customer GetCustomer()
        {
            return this.customer;
        }

        public DateTime GetDate()
        {
            return this.date;
        }

        public int GetNumberOfItems()
        {
            return this.orderdetails.Count;
        }

        public String GetStatus()
        {
            return this.status;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + this.date;
        }

        public double TotalPayment()
        {
            double payment = 0;
            foreach (Payment p in this.payments)
            {
                payment += p.GetAmount();
            }
            return payment;
        }
    }
}
