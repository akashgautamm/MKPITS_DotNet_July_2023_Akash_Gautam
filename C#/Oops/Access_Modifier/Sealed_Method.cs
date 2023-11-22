using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Method
{
    class Person
    {
        public virtual void display()
        {
            Console.WriteLine("Hello from Person");
        }
    }
    class Student:Person
    {
        public sealed override void display()
        {
            Console.WriteLine("Hello from Student");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Student();
            p.display();
            Console.ReadKey();
        }
    }
}
