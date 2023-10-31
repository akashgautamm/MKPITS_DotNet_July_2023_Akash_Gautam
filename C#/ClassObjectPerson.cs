using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectPerson
{
    class Person
    {
        int age;
        string name, adress;
        public void getdata(int age, string name, string adress)
        {
            this.age = age;
            this.name = name;
            this.adress = adress;
        }
        public void getdisplay()
        {
            Console.WriteLine("Enter Age :" + age);
            Console.WriteLine("Enter Name :" + name);
            Console.WriteLine("Enter Adress :" + adress);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                Person p1=new Person();
                Console.WriteLine("Enter Person Data\nAge ,Name, Adress");
                int age = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                string adress = Console.ReadLine();
                p1.getdata(age, name, adress);
                p1.getdisplay();
                Console.ReadKey();
        }
    }
}
