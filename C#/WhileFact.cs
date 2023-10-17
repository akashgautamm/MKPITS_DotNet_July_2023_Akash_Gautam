using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileFact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("Enter num");
            num=Convert.ToInt32(Console.ReadLine());
            while(num>0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("Fact is {0}", fact);
            Console.ReadKey();
        }
    }
}
