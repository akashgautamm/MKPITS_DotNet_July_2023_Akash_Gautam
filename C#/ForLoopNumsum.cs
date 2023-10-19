using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopNumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int count;
            int sum = 0;
            Console.WriteLine("Enter num");
            num = Convert.ToInt32(Console.ReadLine());

            for (count = 1; count <=num; count++)
            {

                Console.WriteLine(count);
                sum = count + sum;
            }
            Console.WriteLine("Sum of all natural num {0}", sum);
            Console.ReadKey();
        }
    }
}
