using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_IfElse_BankUser
{
    internal class Program
    {
        abstract class Account
        {
            public int Balance = 1000;
            public abstract void deposit(int amount);
            public void show()
            {
                Console.WriteLine("Balance is: " + Balance);
                Console.WriteLine("-----------------------------");
            }
        }
        class Saving:Account
        {
            public override void deposit(int amount)
            {
                int intrest = 500;
                Balance = Balance + amount+intrest;
                Console.WriteLine("Saving account amount deposit successful...");
               
            }
        }
        class Current:Account
        {
            public override void deposit(int amount)
            {
                Balance = Balance + amount;
                Console.WriteLine("Current account amount  deposit successful....");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount to deposit in your account: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saving or Current");
            string choice = Console.ReadLine();

            Account act = null;
            if (choice == "Saving")
            {
                act = new Saving();
            }
            else if(choice=="Current")
            {
                act = new Current();
            }
            else
            {
                Console.WriteLine("Invalid ");
            }
            act.deposit(amount);
            act.show();
            Console.ReadKey();
        }
    }
}
