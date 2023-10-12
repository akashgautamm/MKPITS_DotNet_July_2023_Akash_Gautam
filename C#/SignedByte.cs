using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignedByte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte b;
            Console.WriteLine("Enter Byte Num");
            b = Convert.ToSByte(Console.ReadLine());  //Signed Byte
            Console.WriteLine("Byte Num" + b);
            Console.ReadKey();
        }
    }
}
