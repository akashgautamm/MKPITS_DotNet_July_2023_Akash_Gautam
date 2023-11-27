using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileTable2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;
            int count = 1;
            int count1 = 1;
            
            Console.WriteLine("Enter Num:");
            num=Convert.ToInt32(Console.ReadLine());

            while(count<=10)
            {
                count1 = 1;
                while (count1<=num)
                {
                    
                    Console.WriteLine("{0}*{1}={2}", count, count1, count1 * count);
                    Console.Write("\t");
                    count1++;

                }
                count++;
                Console.WriteLine();
                    
            }
            Console.ReadKey();
        }
    }
}
