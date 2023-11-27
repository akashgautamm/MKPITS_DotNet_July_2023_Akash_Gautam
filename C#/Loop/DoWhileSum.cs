using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DowhileOddsum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int count = 1;
            Console.WriteLine("Enter Num");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
              if(count%2==1)
                {
                    Console.WriteLine(count);
                }
                count++;
            }
            while (count <= num);
            Console.ReadKey();
        }
    }
}
