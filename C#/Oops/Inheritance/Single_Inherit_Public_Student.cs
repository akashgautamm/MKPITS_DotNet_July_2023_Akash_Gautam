using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inherit_Public_Student
{
    public class Student
    {
        public int Id;
        public string Name;

    }
    public class Derived:Student
    {
        public string Adress;
        public int Fees;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.Id = 123;
            d.Name = "John";
            d.Adress = "Nagpur";
            d.Fees = 1100;
            Console.WriteLine("Student Id: " + d.Id);
            Console.WriteLine("Student Name: " + d.Name);
            Console.WriteLine("Student Adress: " + d.Adress);
            Console.WriteLine("Student Fees: " + d.Fees);
            Console.ReadKey();


        }
    }
}
