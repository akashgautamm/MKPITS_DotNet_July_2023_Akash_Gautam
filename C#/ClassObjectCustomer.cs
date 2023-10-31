using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectCustomer
{
    class Customer
    {
        public int cstid;
        public string cstname;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.cstid = 123;
            c1.cstname = "Akash";
            Console.WriteLine("Customer Id =" + c1.cstid);
            Console.WriteLine("Customer Name =" + c1.cstname);
           Console.ReadKey();
        }
    }
}
