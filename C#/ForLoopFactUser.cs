using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopFactUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int count,num;
            Console.WriteLine("Enter Num:");
            num = Convert.ToInt32(Console.ReadLine());

            for (count = num; count >0; count--)
            {
                fact = fact * count;
               

            }
            Console.WriteLine("Factorial is {0}", fact);
            Console.ReadKey();
        }
    }
}
