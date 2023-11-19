using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Polymorphism_Bank
{
    class Account
    {
        public int actno;
        public int balance = 1000;
        public  virtual void deposit(int actno,int amt)
        {
            Console.WriteLine("Deposite method of account class");
        }
        public void showbalance()
        {
            Console.WriteLine("Account Number: " + actno);
            Console.WriteLine("Balance is : " + balance);
            Console.WriteLine("-------------------------------");
        }
    }
    class Current:Account
    {
       
        public override void deposit(int actno, int amt)
        {
            this.actno = actno;
            
            balance = amt + balance;
            Console.WriteLine("Amount deposite successful");
        }
        
    }
    class Saving:Account
    {
       
        public override void deposit(int actno, int amt)
        {
            int intrest = 500;
            this.actno = actno;
         
            balance = amt + balance+intrest;
            Console.WriteLine("Saving amount deposite successful");
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new Current();
            Console.WriteLine("Enter Account Num:");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount Deposit: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            act.deposit(actno, amount);
            act.showbalance();

            Account act1 = new Saving();
            Console.WriteLine("Enter Account Num: ");
            int actno1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount Deposit: ");
            int amount1= Convert.ToInt32(Console.ReadLine());
            act1.deposit(actno1, amount1);
            act1.showbalance();
            Console.ReadKey();





        }
    }
}
