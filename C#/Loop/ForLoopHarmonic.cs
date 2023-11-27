using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopHarmonic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float counter, num,sum=0;
            Console.WriteLine("Enter Num:");
            num = Convert.ToSingle(Console.ReadLine());

            for(counter=1;counter<=num;counter++)
            {
                Console.WriteLine("1/{0}", counter);
                sum+= 1 / counter;
            }
            Console.WriteLine("Sum is {0}", sum);
            Console.ReadKey();
        }
    }
}
