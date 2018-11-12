using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Customer
    {
        public int CId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }
        public bool Status { get; set; }
        public override string ToString() => CId + "" + Name + " " + City + " " + Balance + " " + Status + " ";
    }

    class class5
    {
        public static void Main()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer{CId=101,Name="AAA",City="Hyd",Balance=4698.6,Status=true},
                new Customer{CId=102,Name="BBB",City="Ban",Balance=6598.63,Status=false},
                new Customer{CId=103,Name="CCC",City="Mum",Balance=6788.55,Status=true}
            };


           
            foreach(Customer customer in customers)
            {
                //Console.WriteLine(customer.CId + " " + customer.Name + " " + customer.City + " " + customer.Balance + " " + customer.Status);

                Console.WriteLine(customer);
            }

            Console.ReadLine();
        }
    }
}
