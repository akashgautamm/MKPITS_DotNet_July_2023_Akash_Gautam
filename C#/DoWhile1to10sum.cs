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
            Console.WriteLine("Enter num:");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(counter);
                sum = counter + sum;
                counter++;


            }
            while (counter <= num);
            Console.WriteLine("All natural number sum is= {0}", sum);
            Console.ReadKey();
        }
    }
}
