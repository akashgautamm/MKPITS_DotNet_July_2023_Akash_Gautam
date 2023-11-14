using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Static_Hello
{
    internal class Program
    {
        class Hello
        {
            public static void display()
            {
                Console.WriteLine("Hello from Static");
            }
        }
        static void Main(string[] args)
        {
            Hello.display();
            Console.ReadKey();
        }
    }
}
