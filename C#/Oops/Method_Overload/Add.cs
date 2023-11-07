using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, result=0;
            Console.WriteLine("Enter Num 1:");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  Num 2:");
             n2=Convert.ToInt32(Console.ReadLine());

            result = n1 + n2;
            Console.WriteLine("Total is " + result);
            Console.ReadKey();
        }
    }
}
