using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfRadius_Circum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  radius;
            float area, circ;

            Console.WriteLine("Enter Radius");
            radius = Convert.ToInt32(Console.ReadLine());

            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;

            Console.WriteLine("Area of circle " + area);
            Console.WriteLine("Circum of circle" + circ);

            Console.ReadKey();

        }
    }
}
