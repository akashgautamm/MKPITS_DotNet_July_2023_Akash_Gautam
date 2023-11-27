using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileEvenNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            while(num<=10)
            {
                if(num%2==0)
                {
                    Console.WriteLine("{0} Even Num", num);
                }
                num++;
                
            }
            Console.ReadKey();
        }
    }
}
