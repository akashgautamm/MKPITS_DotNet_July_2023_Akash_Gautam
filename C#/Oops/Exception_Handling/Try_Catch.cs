using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("Enter Num1:");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num2:");
            num2=Convert.ToInt32(Console.ReadLine());
            int res = 0;
            try
            {
                res = num1 / num2;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Cannot Divisible by zero");
            }
            Console.WriteLine("Res: " + res);
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
