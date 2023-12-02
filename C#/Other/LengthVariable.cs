using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthVariable
{
    internal class Program
    {
        static int  display(params int[]num)
        {
            int i;int total = 0;
            for( i=0;i<num.Length; i++)
            {
                total = total + num[i];
            }
            return total;
        }
        static void Main(string[] args)
        {
            int result;
            result = display(1, 2, 3, 4);
            Console.WriteLine("Total is " + result);

            Console.ReadKey();


        }
    }
}
