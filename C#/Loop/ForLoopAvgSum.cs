using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopAvgSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum=0;
            int avg;
            int count;
            Console.WriteLine("Enter Num:");
            num = Convert.ToInt32(Console.ReadLine());
            for(count=1;count<=num;count++)
            {
                Console.WriteLine(count);
                sum = count + sum;
                
            }
            Console.WriteLine("Total is : {0}", sum);
            avg = sum / num;
            Console.WriteLine("Average is : {0}", avg);
            Console.ReadKey();

        }
    }
}
