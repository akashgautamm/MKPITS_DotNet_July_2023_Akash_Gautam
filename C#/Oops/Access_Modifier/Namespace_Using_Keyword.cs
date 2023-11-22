
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using first;
using second;
namespace first
{
    class Hello
    {
        public void display()
        {
            Console.WriteLine("Hello from Namespace first");
        }
    }
}
namespace second
{
        class Welcome
        {
            public void welcome()
            {
                Console.WriteLine("Welcome from namespace second");
            }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello h = new Hello();
            h.display();
            Welcome w = new Welcome();
            w.welcome();
            Console.ReadKey();
        }
    }
}
