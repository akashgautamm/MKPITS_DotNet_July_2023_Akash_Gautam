using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectEmployeUser
{
    class Employe
    {
        int num,salary;
        string name, desig;
        public void getdata(int num,string name,string desig,int salary)
        {
            this.num = num;
            this.name = name;
            this.desig = desig;
            this.salary = salary;
           
        }
        public void getdisplay()
        {
            Console.WriteLine("Employe number :" + num);
            Console.WriteLine("Employe name :" + name);
            Console.WriteLine("Employe designation :" + desig);
            Console.WriteLine("Employe salary :" + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe e1 = new Employe();
            Console.WriteLine("Enter : Number, Name, Designation, Salary");
            int num=Convert.ToInt32(Console.ReadLine());
            string name= Console.ReadLine();
            string desig= Console.ReadLine();
            int salary=Convert.ToInt32(Console.ReadLine());
            e1.getdata(num, name, desig, salary);
            e1.getdisplay();
            Console.ReadKey();
        }
    }
}
