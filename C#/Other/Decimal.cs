using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal b2;
            Console.WriteLine("enter number");
            b2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("number " + b2);
            Console.ReadKey();


        }
    }
}
