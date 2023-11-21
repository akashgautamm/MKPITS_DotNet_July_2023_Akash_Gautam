using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Keyword_Animal
{
    class Animal
    {
        public string color = "White";
    }
    class Dog:Animal
    {
        public string color = "White";
        public void display()
        {
            
            Console.WriteLine("Dog Color: " + color);
            Console.WriteLine("Animal Color: " + base.color);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.display();
            Console.ReadKey();
        }
    }
}
