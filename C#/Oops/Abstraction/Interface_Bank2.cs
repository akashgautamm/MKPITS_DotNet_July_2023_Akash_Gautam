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
    }
    class Account
    {
        public int act;
        public int balance = 1000;
        public int intrest = 500;
    }
    class Saving:Account,Bank
    {
        public string deposit(int act,int amt)
        {
            this.act = act;
            balance = balance + amt + intrest;
            return "Account Number: " + act + "\nBalance is: " + balance;


        }
    }
    class Current:Account,Bank
    {
        public string deposit(int act,int amt)
        {
            this.act = act;
            balance = balance + amt;
            return "Account Number: " + act + "Balance is: " + balance;

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
            if(choice=="Saving")
            {
                b = new Saving();
            }
            else if(choice=="Current")
            {
                b = new Current();
            }
             string res= b.deposit(act, amt);
            Console.WriteLine(res);
            Console.ReadKey();
            
        }
    }
}
