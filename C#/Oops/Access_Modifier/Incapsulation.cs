using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Incapsulation
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
namespace Incapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 26;
            s.Name = "Akash";
            s.Address = "Nagpur";
            Console.WriteLine("Id: " + s.Id);
            Console.WriteLine("Name: " + s.Name);
            Console.WriteLine("Address: " + s.Address);
            Console.ReadKey();
        }
    }
}
