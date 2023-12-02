using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectCircle
{
    internal class Program
    {
        class Circle
        {
            float radius;

            public void getdata(float radius)
            {
                this.radius = radius;
               
            }
            public void getdisplay()
            {
                float circ = 2 * 3.14f * radius;
                float area = 3.14f * radius * radius;
                Console.WriteLine("Circumference is " + circ);
                Console.WriteLine("Area of circle is " + area);
            }
        }
        static void Main(string[] args)
        {
            Circle c1= new Circle();
            Console.WriteLine("Enter Radius :");
            float radius = Convert.ToSingle(Console.ReadLine());

            c1.getdata(radius);
            c1.getdisplay();
            Console.ReadKey();

        }
    }
}
