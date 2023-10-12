using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ushort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort b;
            Console.WriteLine("Enter Num");
            b = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Num is " + b);
            Console.ReadKey();
        }
    }
}
