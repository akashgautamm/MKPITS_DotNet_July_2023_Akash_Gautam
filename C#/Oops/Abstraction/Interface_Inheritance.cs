using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Inheritance
{
    interface Drawable
    {
        void Draw();
    }
    class Circle:Drawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Circle...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Drawable d = new Circle();
            d.Draw();
            Console.ReadKey();
        }
    }
}
