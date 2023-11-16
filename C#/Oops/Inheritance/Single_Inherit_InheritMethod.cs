using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inherit_InheritMethod_ClassCar
{
    class Car
    {
        public void Start()
        {
            Console.WriteLine("Start Engine.....");
        }

    }
    class Derived:Car
    {
        public void Stop()
        {
            Console.WriteLine("Stop Engine.....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.Start();
            d.Stop();
            Console.ReadKey();
        }
    }
}
