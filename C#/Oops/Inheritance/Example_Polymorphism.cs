using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Person
    {
        public string name;
        public string address;
    }
    class Employe:Person
    {
        public int id;
        public int salary;
    }
    class Part:Employe
    {
        public int hrs;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Part p = new Part();
            p.name = "Akash";
            p.address = "Nagpur";
            p.id = 1;
            p.salary = 25000;
            p.hrs = 1;
            Console.WriteLine(p.name);
            Console.WriteLine(p.address);
            Console.WriteLine(p.id);
            Console.WriteLine(p.salary);
            Console.WriteLine(p.hrs);
            Console.ReadKey();
        }
    }
}
