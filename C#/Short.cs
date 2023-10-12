using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short b;
            Console.WriteLine("Enter Num");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Num is " + b);
            Console.ReadKey();
        }
    }
}
