using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsignedLong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong b;
            Console.WriteLine("Enter num");
            b = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Result " + b);
            Console.ReadLine();
        }
    }
}
