using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceCalculate
{
    internal class Program
    {
        static void calculate(int radius,ref float area,ref float circ)
        {
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;

        }
        static void Main(string[] args)
        {
            int radius;
            float area=0;
            float circ=0;
            Console.WriteLine("Enter Radius:");
            radius = Convert.ToInt32(Console.ReadLine());
            calculate(radius, ref area, ref circ);
            Console.WriteLine("Area is " + area);
            Console.WriteLine("Circum is " + circ);
            Console.ReadKey();
        }
    }
}
