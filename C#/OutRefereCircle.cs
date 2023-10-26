using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OutRefereCircle
{
    internal class Program
    {
        static void display(int radius , out float area, out float circ)
        {
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
        }
        static void Main(string[] args)
        {
            int radius;
            float  area;
            float circ;
            Console.WriteLine("Enter Num:");
            radius = Convert.ToInt32(Console.ReadLine());
            display(radius, out area, out circ);
            Console.WriteLine("Area is " + area);
            Console.WriteLine("Circum is " + circ);
            Console.ReadKey();

        }
    }
}
