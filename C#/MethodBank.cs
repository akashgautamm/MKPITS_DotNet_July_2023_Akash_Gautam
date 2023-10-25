using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodBank
{
    internal class Program
    {
        static void bank(int amount,int choose)
        {
            int balance = 1000;
         
            if(choose==1)
            {
                balance = balance + amount;
                Console.WriteLine("Deposite amount is " + balance);

            }
            else if(choose==2)
            {
                balance = balance - amount;
                Console.WriteLine("Withdrawl amount is " + balance);

            }


        }
        static void Main(string[] args)
        {
            int amt;
            int no;
            int choice;
            Console.WriteLine("Enter Account Num:");
            no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount:");
            amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Withdrawl\n2.Deposite");
            choice = Convert.ToInt32(Console.ReadLine());

            bank(amt,choice);
            Console.ReadKey();
        }
    }
}
