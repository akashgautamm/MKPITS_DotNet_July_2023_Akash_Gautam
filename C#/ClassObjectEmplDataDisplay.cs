using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectEmployeDataDisplay
{
    class Employe
    {
        int num;
        string name;
        string desig;
        int salary;
        public void getdata(int no,string na,string des,int sal)
        {
            num = no;
            name = na;
            desig = des;
            salary = sal;
        }
        public void getdisplay()
        {
            Console.WriteLine("Employe Number :" + num);
            Console.WriteLine("Employe Name :" + name);
            Console.WriteLine("Employe Designation :" + desig);
            Console.WriteLine("Employe Salary :" + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Employe e1 = new Employe();
            e1.getdata(997075, "Akash", "Manager", 50000);
            e1.getdisplay();
            Console.ReadKey();
        }
    }
}
