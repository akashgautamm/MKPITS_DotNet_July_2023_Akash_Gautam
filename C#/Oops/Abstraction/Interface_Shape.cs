using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Shape
{
    interface Shape
    {
        void draw();
    }
    class Rectangle:Shape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle Draw...");
        }
    }
    class Circle:Shape
    {
        public void draw()
        {
            Console.WriteLine("Circle Draw");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape r;
            r=new Rectangle();
            r.draw();

            Shape c;
            c = new Circle();
            c.draw();
            Console.ReadKey();

        }
    }
}
