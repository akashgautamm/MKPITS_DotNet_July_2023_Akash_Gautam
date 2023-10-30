using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayParameMethod
{
    internal class Program
    {
        static void sum(int[] num)
        {
            int sum = 0;
            for(int cnt=0;cnt<num.Length;cnt++)
            {
                Console.WriteLine(num[cnt]);
                sum = sum + num[cnt];
            }
            Console.WriteLine(sum);
        }

        static void Main(string[] args)
        {
            int[] num = { 1,2,5 };
            sum(num);
            int[] num1 = { 4, 5, 6 };
            sum(num1);

            Console.ReadKey();
            
        }
        
       
    }
}
