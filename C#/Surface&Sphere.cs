using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphere_Surface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float sphere, surface;
            Console.WriteLine("Enter Radius");
            radius = Convert.ToInt32(Console.ReadLine());
            sphere = 4*3.14f * radius * radius;
            surface = 4/3 * 3.14f * radius*radius*radius;
            Console.WriteLine("Sphere is " + sphere);
            Console.WriteLine("Surface " + surface);
            Console.ReadKey();
        }
    }
}
