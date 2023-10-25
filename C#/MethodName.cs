using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodName
{
    internal class Program
    {
        static void display(string name)
        {
            Console.WriteLine("Welcome Friend {0}!\nHave a nice day!", name);
        }
        static void Main(string[] args)
        {
            string n;
            Console.WriteLine("Enter Name:");
            n = Console.ReadLine();
            display(n);
            Console.ReadKey();
        }
    }
}
