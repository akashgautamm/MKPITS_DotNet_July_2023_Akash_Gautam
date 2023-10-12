using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b;
            Console.WriteLine("Enter Num");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Num is" + b);
            Console.ReadKey();
        }
    }
}
