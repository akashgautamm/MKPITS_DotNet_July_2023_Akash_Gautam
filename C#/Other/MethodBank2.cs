using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodBank
{
    internal class Program
    {
        static void bank(int amount)
        {
            int balance = 1000;
            balance = balance + amount;
            Console.WriteLine("Deposite amount is " + balance);
            
            balance = balance - amount;
            Console.WriteLine("Withdrawl amount is " + balance);


        }
        static void Main(string[] args)
        {
            int amt;
            int no;
           
            Console.WriteLine("Enter Account Num:");
            no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount:");
            amt = Convert.ToInt32(Console.ReadLine());
            

            bank(amt);
            Console.ReadKey();
        }
    }
}
