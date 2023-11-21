using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Bank
{
    interface Bank
    {

        string deposit(int actno, int amt);
    }   
    class Saving:Bank
    {
        public int actno;
        public int balance = 1000;
        public int intrest = 500;
        public string deposit(int actno,int amt)
        {
            this.actno = actno;
            balance = balance + amt+intrest;
            return "Balance is from Saving bank " + balance+"Account Number: "+actno;
            
        }
    }
    class Current:Bank
    {
        public int actno;
        public int balance = 1000;
        public string deposit(int actno,int amt)
        {
            this.actno = actno;
            balance = balance + amt;
            return "Balance is from Current account:" + balance + "Account Number: " + actno;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account Number:");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount Deposit");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saving or Current");
            string choice=Convert.ToString(Console.ReadLine());
           

            Bank b=null;
            if(choice=="Saving")
            {
                b=new Saving();
            }
            else if(choice=="Current")
            {
                b = new Current();
            }
            string res= b.deposit(actno,amount);
            Console.WriteLine(res);
            Console.ReadKey();
            
        }
    }
}
