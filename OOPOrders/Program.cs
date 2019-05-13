using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrders
{
    class Program
    {
        static void Main(string[] args)
        {

            // Setup our bookshop
            Item[] books = {
                new Item("How to code in C#", 0.5, 11.99, true),
                new Item("The art of passing in-class tests", 0.75, 9.99, true),
                new Item("Computer Systems and Practice", 0.6, 12.99),
                new Item("The real guide to managing data", 0.4, 23.99, true)
            };

            // Print out the books
            foreach (Item book in books)
            {
                Console.WriteLine(book);
            }

            // Outputs a blank line
            Console.WriteLine();

            // Create a new customer
            Customer c = new Customer("Jessica Muirhead", "Prifysgol Glyndŵr Wrecsam, Ffordd yr Wyddgrug, Wrecsam LL11 2AW");

            // Create a new order for this customer
            Order o = new Order(c);

            // Add some books to the order
            o.AddOrderDetail(new Orderdetail(books[0], 1));
            o.AddOrderDetail(new Orderdetail(books[3], 2));

            // Print out some info about the order
            Console.WriteLine(o);
            Console.WriteLine("Total cost: £" + (o.CalcSubTotal() + o.CalcTax()));
            Console.WriteLine("Total weight: " + o.CalcWeight());

            // Now pay for the order - I'm being awkward and paying £10 in cash and the rest by credit card!
            Payment payment1 = new Cash(10);
            o.AddPayment(payment1);
            Credit payment2 = new Credit("1234 5678 8765 4321", "Visa", new DateTime(2019,11,30), 61.97);
            payment2.Authorize();
            o.AddPayment(payment2);

            // Check how much we have paid
            Console.WriteLine("Total payment: £" + o.TotalPayment());

            // Pause the console so we can see the output
            Console.ReadKey();
        }
    }
}
