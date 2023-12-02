using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b;
            Console.WriteLine("Enter Byte num");
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Byte Num " + b);
            Console.ReadKey();
        }
    }
}
