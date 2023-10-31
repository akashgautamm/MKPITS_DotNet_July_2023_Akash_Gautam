using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjCustomerDataDisplay
{
    class Customer
    {
        int cstid;
        string cstname;
        public void getdata(int ci,string cn)
        {
            cstid = ci;
            cstname = cn;
        }
        public void getdisplay()
        {
            Console.WriteLine("Customer ID :" + cstid);
            Console.WriteLine("Customer Name :" + cstname);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.getdata(123, "Akash");
            c1.getdisplay();
            Console.ReadKey();
        }
    }
}
