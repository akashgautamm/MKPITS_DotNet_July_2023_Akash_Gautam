using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace First
{
    class Hello
    {
        public void display()
        {
            Console.WriteLine("Hello from namespace first");
        }
    }
}
namespace Second
{
    class Hello
    {
        public void display()
        {
            Console.WriteLine("Hello from namespace second");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            First.Hello h1 = new First.Hello();
            h1.display();
            Second.Hello h2 = new Second.Hello();
            h2.display();
            Console.ReadKey();
        }
    }
}
