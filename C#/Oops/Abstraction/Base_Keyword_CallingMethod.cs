using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword_Callingmethod
{
    class Company
    {
        public string name = "Fendhal";
        public void display()
        {
            Console.WriteLine("Company Name: " + name);
        }
    }
    class Frenchies:Company
    {
        public string name = "Mkpits";
        public void display ()
        {
            base.display();
            Console.WriteLine("Franchies Name: " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Frenchies f = new Frenchies();
            f.display();
            Console.ReadKey();
        }
    }
}
