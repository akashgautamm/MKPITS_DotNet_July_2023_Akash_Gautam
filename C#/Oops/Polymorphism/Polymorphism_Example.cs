using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Example
{
    class Base
    {
        public virtual void display()
        {
            Console.WriteLine("Hello from base class");
        }
    }
    class Child:Base
    {
        public override void display()
        {
            Console.WriteLine("Hello from child class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Base b = new Child();
            b.display();
            Console.ReadKey();
        }
    }
}
