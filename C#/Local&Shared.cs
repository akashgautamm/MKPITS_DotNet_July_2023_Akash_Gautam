using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Shared
{
    internal class Program
    {
        static int num = 20;
        static void display()
        {
            int num = 10;
            Console.WriteLine("Num 1"+num);
        }
        static void Main(string[] args)
        {
            display();
            Console.WriteLine("Num 2"+num);
            Console.ReadKey();
        }
    }
}
