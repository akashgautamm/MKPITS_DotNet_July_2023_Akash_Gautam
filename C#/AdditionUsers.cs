using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AdditionProgram
{
    internal class Addition
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            Console.WriteLine("Enter Num 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("Addition is " + sum);
            Console.ReadKey();
            
        }
    }
}
