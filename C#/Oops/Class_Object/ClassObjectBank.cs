using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectBank
{
    internal class Program
    {
        class Bank
        {
            string name;
            int no;
            int bal;
            int amt;
            int with, dep;
            public void getdata(string name,int no,int amt, int bal)
            {
                this.name = name;
                this.no = no;
                this.amt = amt;
                this.bal = bal;
               
            }
            public void getdisplay()
            {
                dep = bal + amt;

                with = bal - amt;

                Console.WriteLine("Customer Name :" + name);
                Console.WriteLine("Customer Acc num :" + no);
                Console.WriteLine("Customer Enter Amount :" + amt);
                Console.WriteLine("Deposite Amount :" + dep);
                Console.WriteLine("Withdrawl Amount :" + with);


            }
        }
        static void Main(string[] args)
        {
            Bank b1= new Bank();
            int bal = 1000;
            int amt, no;
            string name;
            Console.WriteLine("Enter Name :");
            name=Console.ReadLine();
            Console.WriteLine("Enter Account Num :");
            no=Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Amount :");
            amt = Convert.ToInt32(Console.ReadLine());
            b1.getdata(name,no,amt,bal);
            b1.getdisplay();
            Console.ReadKey();



        }
    }
}
