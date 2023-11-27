using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int count;
            int sum = 0;
            Console.WriteLine("Enter Num:");
            num = Convert.ToInt32(Console.ReadLine());

            for (count = 1; count <= num; count++)
            {
                if (count % 2 == 0)
                {
                    Console.WriteLine(count);
                    sum = count + sum;
                }

            }
            Console.WriteLine("Total sum is: {0}", sum);
            Console.ReadKey();
        }
    }
}
