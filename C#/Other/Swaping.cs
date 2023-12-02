using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            a = a - b;
            b = a + b;
            a = b - a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();

        }
    }
}
