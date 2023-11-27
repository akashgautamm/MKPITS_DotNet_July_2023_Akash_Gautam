using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileNaturalNumUsers
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int num,sum=0,counter=1;
            Console.WriteLine("Enter num:");
            num=Convert.ToInt32(Console.ReadLine());
            while(counter<=num)
            {
                Console.WriteLine(counter);
                sum = counter + sum;
                
                counter++;
            }
            Console.WriteLine("Sum of all natural number="+sum);
            Console.ReadKey();
        }
        
    }
}
