using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Return_Bank
{
    abstract class Account
    {
        public int actno;
        public int balance = 1000;
        public abstract string deposit(int actno, int amount);
        public abstract string withdrawl(int amount, int actno);
        public string show()
        {
            
            return "Account Num: "+actno+"\nBalance is: " + balance;
        }
    }
    class Saving : Account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            int intrest = 500;
            balance = balance + intrest + amount;
            return "amount deposited successfully with interest in saving class";
        }
        public override string withdrawl(int actno, int amount)
        {
            this.actno = actno;
            
            balance = balance - amount;
            return "amount withdrawl successfully with interest in saving class";
        }


    }
    class Current:Account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "amount deposited successfully without interest in saving class";
        }
        public override string withdrawl(int actno, int amount)
        {
            this.actno = actno;

            balance = balance - amount;
            return "amount withdrawl successfully with interest in current class";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account Num:");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount: ");
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

            if (choice1 == "Withdrawl")
            {
                String res=act.withdrawl(actno, amount);
            }
            else if (choice1 == "Deposit")
            {
                String res=act.deposit(actno, amount);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            
            string res1 = act.show();
            Console.WriteLine(res1);
            Console.ReadKey();
        }
    }
}
