using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inherit_Protected_AcessModifier
{
    public class Employe
    {
        string name;
        int id;
        protected void dataemploye(string name,int id)
        {
            this.name = name;
            this.id = id;
        }
        protected void displayemploye()
        {
            Console.WriteLine("Employe Name: " + name);
            Console.WriteLine("Employe Id: " + id);
        }
    }
    public class Student:Employe
    {
        string name;
        int fees;
        public void datastudent(string name,int fees)
        {
            dataemploye("Akshay", 123);
            this.name = name;
            this.fees = fees;
        }
        public void displaystudent()
        {
            displayemploye();
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Fees: " + fees);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.datastudent("Rajesh", 1246);
            s.displaystudent();
            Console.ReadKey();
        }
    }
}
