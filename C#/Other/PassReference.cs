using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassRefer
{
    internal class Program
    {
        static void display(ref int num)
        {
            num = 10;
            Console.WriteLine(num);
        }
        static void Main(string[] args)
        {
            int num = 20;
            display(ref num);
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
