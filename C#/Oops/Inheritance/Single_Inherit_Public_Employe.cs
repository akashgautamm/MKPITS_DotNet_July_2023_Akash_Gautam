using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inherit_Public_Employe
{
    public class Employe
    {
        public string name = "John";
        public int id = 1;
    }
    public class Programs:Employe
    {
        public int salary = 50000;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programs p = new Programs();
            Console.WriteLine("Employe Name: " + p.name);
            Console.WriteLine("Employe Id: " + p.id);
            Console.WriteLine("Employe Salary: " + p.salary);
            Console.ReadKey();
        }
    }
}
