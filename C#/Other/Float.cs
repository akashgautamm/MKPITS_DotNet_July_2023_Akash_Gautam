using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float b;
            Console.WriteLine("Enter Num");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Num is " + b);
            Console.ReadKey();
        }
    }
}
