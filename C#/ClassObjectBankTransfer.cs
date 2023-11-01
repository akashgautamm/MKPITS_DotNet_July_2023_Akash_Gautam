using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectBankTransfer
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public int Balance { get; set; }
        
        public void display()
        {
            Console.WriteLine("Account Number :" + AccountNumber);
            Console.WriteLine("Account Holder Name :" + AccountHolderName);
            Console.WriteLine("Enter  Balance :" + Balance);


        }
        public void transfer1(BankAccount b11)
        {
             Balance = Balance + b11.Balance;
            b11.Balance = 0;
        }
       
        public void showbalance()
        {
            Console.WriteLine("current balance for account no {0} is {1} ", AccountNumber, Balance);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount();
            BankAccount b2 = new BankAccount();

            Console.WriteLine("Enter Account Number :");
            b1.AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Holder Name :");
            b1.AccountHolderName = Console.ReadLine();
            Console.WriteLine("Enter Balance :");
            b1.Balance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Account Number :");
            b2.AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Holder Name :");
            b2.AccountHolderName = Console.ReadLine();
            Console.WriteLine("Enter Balance :");
            b2.Balance = Convert.ToInt32(Console.ReadLine());

            b1.display();
            b2.display();

            b1.transfer1(b2);
           
            b1.showbalance();
            b2.showbalance();
            Console.ReadKey();

        }
    }
}
