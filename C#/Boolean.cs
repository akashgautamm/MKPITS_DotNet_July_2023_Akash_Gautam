using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booleaan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean b;
            Console.WriteLine("Enter Num");
            b = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Num is" + b);
            Console.ReadKey();
        }
    }
}
