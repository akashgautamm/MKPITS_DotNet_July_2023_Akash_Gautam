using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword_Constructor
{
    class Company
    {
        public string name="Mkcl";
        public Company()
        {
            Console.WriteLine("Base class Constructor calling");
            Console.WriteLine("Compnay Name: " + name);
        }
    }
    class Frenchies:Company
    {
        public string name = "Mkpit";
        public Frenchies()
        {
            Console.WriteLine("Derived class Constructor Calling");
            Console.WriteLine("Company Name: " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Frenchies f = new Frenchies();
            Console.ReadKey();
        }
    }
}
