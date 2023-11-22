using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class_Student
{
    abstract class Person
    {
        public string name;
    }
    class Student:Person
    {
        public int rno;
    }
    sealed class Parttime:Student
    {
        public int hrs;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parttime p = new Parttime();
            p.name = "Akash";
            p.rno = 123;
            p.hrs = 10;
            Console.WriteLine("Name: " + p.name);
            Console.WriteLine("Rno: " + p.rno);
            Console.WriteLine("Hours: " + p.hrs);
            Console.ReadKey();
        }
    }
}
