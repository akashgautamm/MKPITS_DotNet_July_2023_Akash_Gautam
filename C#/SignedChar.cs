using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignedChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char b;
            Console.WriteLine("Enter Char");
            b = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Char is" + b);
            Console.ReadKey();
        }
    }
}
