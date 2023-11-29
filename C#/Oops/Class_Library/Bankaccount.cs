using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankaccount
{
    public abstract class Account
    {
        public int balance = 1000;
        public int actno;
        
        public abstract string deposit(int actno, int amount);
        public string withdrawl(int actno, int amount)
        {
            this.actno = actno;
            string res=null;
            if (balance < amount)
            {
                res = "Insufficent balnce";
            }
            else
            {
                balance = balance - amount;
                res = "\nWithdrawl balance is: " + balance.ToString() + "\nAccount Number: " + actno;
            }
            return res;
        }
        public string showbalance()
        {
            return"Balance is: "+balance.ToString();
        }
    }
     public  class Saving:Account
    {
        public  override string deposit(int actno, int amount)
        {
            this.actno = actno;
            int intrest = 500;
            balance = balance + amount+intrest;
            return "\nSaving Balance is: " + balance.ToString()+"\nAccount Number: "+actno; 
        }
    }
    public class Current:Account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno= actno;
            balance = balance + amount;
            return "Current Balance is: " + balance.ToString() +"\nAccount Number: "+actno;
        }
    }
}
