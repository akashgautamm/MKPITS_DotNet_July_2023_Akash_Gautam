using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_nonabstract_Ifelse_Bank_withdrawl_user
{
    abstract class Account
    {
        public int amount;
        public int balance = 1000;
        public abstract void deposit(int amount);
        public abstract void withdrawl(int amount);
        public void show()
        {
            Console.WriteLine("Balance is: " + balance);
        }
        
    }
    class Saving:Account
    {
        public override void deposit(int amount)
        {
            int intrest = 500;
            balance = balance + intrest + amount;
            
        }
        public override void withdrawl(int amount)
        {
            balance = balance - amount;
        }
    }
    class Current:Account
    {
        public override void deposit(int amount)
        {
            balance = balance + amount;

        }
        public override void withdrawl(int amount)
        {
            balance = balance - amount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount to deposit in your account");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saving or Current");
            string choice = Console.ReadLine();
            Console.WriteLine("Withdrawl or Deposit");
            string choice1 = Console.ReadLine();


            Account act = null;
            if(choice=="Saving")
            {
                act = new Saving();
            }
            else if(choice=="Current")
            {
                act = new Current();

            }
            else
            {
                Console.WriteLine("Invalid");
            }
            if(choice1=="Widthdrawl")
            {
                act.withdrawl(amount);
            }
            else if(choice1=="Deposit")
            {
                act.deposit(amount);
            }
            act.show();
            Console.ReadKey();

        }
    }
}
