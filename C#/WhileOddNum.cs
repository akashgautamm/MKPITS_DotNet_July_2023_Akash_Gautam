using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileOddNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 21;
            while(num<=30)
            {
                if(num%2==1)
                {
                    Console.WriteLine("{0} Odd Num", num);
                }
                num++;
            }
            Console.ReadKey();
        }
    }
}
