using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, counter=1,sum=0,total;
            float avg;
            Console.WriteLine("Enter Num:");
            num=Convert.ToInt32(Console.ReadLine());

            while(counter<=num)
            {
                Console.WriteLine(counter);
                sum = counter + sum;
                counter++;

            }
            Console.WriteLine("Sum of all number is:="+sum);
            total = sum / num;
            Console.WriteLine("Sum of all number is:=" + total);

            Console.ReadKey();
        }
    }
}
