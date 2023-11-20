using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_HelloBank
{
    abstract class Account
    {
        public abstract void deposit();
        public void show()
        {
            Console.WriteLine("Hello from Showbalance");
        }

    }
    class Saving:Account
    {
        public override void deposit()
        {
            Console.WriteLine("Hello from Saving");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act = new Saving();
            act.deposit();
            act.show();
            Console.ReadKey();
        }
    }
}
