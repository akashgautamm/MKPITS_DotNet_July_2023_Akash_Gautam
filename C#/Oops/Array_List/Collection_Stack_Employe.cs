using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Stack_Employe
{
    class Employe
    {
        public int num;
        public string name;
        public string desig;
        public int salary;
        public Employe(int nu,string na,string de,int sa)
        {
            num= nu;
            name = na;
            desig = de;
            salary = sa;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Employe e1 = new Employe(1, "Amit", "Manager", 20000);
            Employe e2 = new Employe(2, "Ashish","Clerk", 10000);
            Stack s = new Stack();
            s.Push(e1);
            s.Push(e2);
            foreach(Employe str in s)
            {
                Console.WriteLine("Number:" + str.num + " Name:" + str.name + " Designation:" + str.desig + " Salary:" + str.salary); ;
            }
            Console.WriteLine("----------After Push---------------");
            s.Pop();
            foreach (Employe str in s)
            {
                Console.WriteLine("Number:" + str.num + " Name:" + str.name + " Designation:" + str.desig + " Salary:" + str.salary); ;
            }

            Console.ReadKey();
        }
    }
}
