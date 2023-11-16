using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inherit_InheritMethodDisplay_Person
{
    class Person
    {
        string Name;
        int Id;
        public void Getdataperson(string Name,int Id)
        {
            this.Name = Name;
            this.Id = Id;
        }
        public void Displayperson()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
        }
    }
    class Student:Person
    {
        int Rno;
        string Name;
        public void Getdatastudent(int Rno,string Name)
        {
           this.Rno= Rno;
            this.Name = Name;
        }
        public void Displaystudent()
        {
            Console.WriteLine("Student Rno: " + Rno);
            Console.WriteLine("Student Name: " + Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Getdataperson("Elvish", 123);
            s.Getdatastudent(456, "James");
            s.Displayperson();
            s.Displaystudent();
            
            Console.ReadKey();
        }
    }
}
