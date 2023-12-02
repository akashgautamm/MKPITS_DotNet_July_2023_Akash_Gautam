using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a, b,c;
            Console.WriteLine("Enter char");
            a = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter char");
            b = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter char");
            c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(a);

            Console.ReadKey();



        }
    }
}
