using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Perimenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area,peri;
            Console.WriteLine("Enter Radius");
            radius = Convert.ToInt32(Console.ReadLine());
            area =3.14f * radius*radius;
            peri = 2 * 3.14f * radius;
            Console.WriteLine("Area is " + area);
            Console.WriteLine("Peri is " + peri);
            Console.ReadKey();

        }
    }
}
