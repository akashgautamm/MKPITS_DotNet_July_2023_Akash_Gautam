using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Polymorphism_Array
{
    interface Animal
    {
        void Makesound();
    }
    class Dog:Animal
    {
        public void Makesound()
        {
            Console.WriteLine("Bhoo-Bhoo");
        }
    }
    class Cat:Animal
    {
        public void Makesound()
        {
            Console.WriteLine("Meow-Meow");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal [] a = new Animal[2];
            a[0] = new Dog();
            a[1] = new Cat();

            for(int i=0;i<a.Length;i++)
            {
                a[i].Makesound();
            }
           
            Console.ReadKey();

           

        }
    }
}
