using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassValue
{
    internal class Program
    {
        static void display(int num)
        {
            num = 20;
            Console.WriteLine(num);
        }
        static void Main(string[] args)
        {
            int num = 10;
            display(num);
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
