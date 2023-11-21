using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instance_Bank_2Class
{
    interface Bank
    {
        string deposit(int act, int amt);
        string withdrawl(int act, int amt);
        string show();

    }
    class Account
    {
        public int act;
        public int balance = 1000;
        public int intrest = 500;
    }
    class Saving : Account, Bank
    {
        public string deposit(int act, int amt)
        {
            this.act = act;
            balance = balance + amt + intrest;
            return "Deposit Amount";


        }
        public string withdrawl(int act,int amt)
        {
            this.act = act;
            balance = balance - amt;
            return "Withdrawl Amount";
        }
        public string show()
        {
            return "Account Number: " + act + "\nBalance is: " + balance;
        }
    }
    class Current : Account, Bank
    {
        public string deposit(int act, int amt)
        {
            this.act = act;
            balance = balance + amt;
            return "Deposit Amount";

        }
        public string withdrawl(int act, int amt)
        {
            this.act = act;
            balance = balance - amt;
            return "Withdrawl Amount";
        }
        public string show()
        {
            return "Account Number: " + act + "\nBalance is: " + balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account Num:");
            int act = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount:");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saving or Current");
            string choice = Console.ReadLine();

            Bank b = null;
            switch(choice)
            {
                case "Saving":
                    b = new Saving();
                    break;
                case "Current":
                    b = new Current();
                    break;


            }
            Console.WriteLine("Deposite or Withdrawl");
            string choice1 = Console.ReadLine();
            string res = null;
            if(choice1=="Deposit")
            {
                res=b.deposit(act, amt);
            }
            if (choice1 == "Withdrawl")
            {
                res = b.withdrawl(act, amt);
            }
            Console.WriteLine(res);
            Console.WriteLine(b.show());
       
            Console.ReadKey();

        }
    }
}
