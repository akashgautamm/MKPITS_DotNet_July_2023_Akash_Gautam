using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Static_Counter
{
    class Bank
    {
        public int actno;
        public string name;
        public static  int count = 0;
        public Bank(int actno,string name)
        {
            this.actno = actno;
            this.name = name;
            count++;
        }
        public void display()
        {
            Console.WriteLine("Bank Number: " + actno);
            Console.WriteLine("Bank Name: " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank(123,"Lucky");
            b1.display();
            Bank b2 = new Bank(456, "January");
            b2.display();
            Console.WriteLine("Total Object are: "+Bank.count);
            Console.ReadKey();


        }
    }
}






















