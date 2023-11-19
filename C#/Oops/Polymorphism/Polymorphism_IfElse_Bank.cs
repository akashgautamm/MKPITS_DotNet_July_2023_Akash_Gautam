using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Ifelse_Bank
{
    class Account
    {
        public int Account_Number;
        public int Balance = 1000;
        public virtual void deposit(int Account_Number,int Amount)
        {
            Console.WriteLine("Deposite Amount of method class");
        }
        public void showbalance()
        {
            Console.WriteLine("Account Number: " + Account_Number);
            Console.WriteLine("Balance is: " + Balance);
        }
    }
    class Current:Account
    {
        public override void deposit(int Account_Number, int Amount)
        {
            this.Account_Number = Account_Number;
            Balance = Balance + Amount;
            Console.WriteLine("Deposit amount successful in current account");
        }
    }
    class Saving : Account
    {
        public override void deposit(int Account_Number, int Amount)
        {
            int Intrest = 500;
            this.Account_Number = Account_Number;
            Balance = Balance + Amount+Intrest;
            Console.WriteLine("Deposit amount successful in Saving account");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account Number: ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Deposit Amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saving or Current");
            string choice = Console.ReadLine();
            Account act = null;
            if(choice =="Current")
            {
                act=new Current();
            }
            else if(choice =="Saving")
            {
                act=new Saving();
            }
            act.deposit(actno,amount);
            act.showbalance();
            Console.ReadKey();
        }
    }
}
