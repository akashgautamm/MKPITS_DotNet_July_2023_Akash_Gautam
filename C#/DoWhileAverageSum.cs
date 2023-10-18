using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileSum1to10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            int counter = 1;
            int total=0;
            
            do
            {
                Console.WriteLine("Enter num:");
                num = Convert.ToInt32(Console.ReadLine());
                sum = num + sum;
                counter++;
               


            }
            while (counter <=10);
            Console.WriteLine("All natural number sum is= {0}", sum);
            total = sum / 10;
            Console.WriteLine("Average is ={0}", total);
            Console.ReadKey();
        }
    }
}
