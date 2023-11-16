using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inherit_InheritMethods_Person_Emp
{
    class Person
    {
        string Name;
        string Adress;
        public void Dataperson(string Name,string Adress)
        {
            this.Name = Name;
            this.Adress = Adress;

        }
        public void Displayperson()
        {
            Console.WriteLine("Person Name: " + Name);
            Console.WriteLine("Person Adress: " + Adress);
        }
    }
    class Student:Person
    {
        int Rno;
        int Fees;
        public void Datastudent(int Rno,int Fees)
        {
            this.Rno = Rno;
            this.Fees = Fees;
        }
        public void Displaystudent()
        {
            Console.WriteLine("Student RollNo: " + Rno);
            Console.WriteLine("Student Fees: " + Fees);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Dataperson("John", "Nagpur");
            s.Datastudent(123, 50000);
            s.Displayperson();
            s.Displaystudent();
            Console.ReadKey();
        }
    }
}
