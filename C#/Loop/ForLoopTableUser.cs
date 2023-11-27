using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopTableUser
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
            for(count=1;count<=10;count++)
            {
                sum = num * count;
                Console.WriteLine("{0} x {1} = {2}", num, count, sum);
            }
            Console.ReadLine();
        }
    }
}
