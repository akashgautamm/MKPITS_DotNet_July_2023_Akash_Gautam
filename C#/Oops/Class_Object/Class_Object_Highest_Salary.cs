using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class_Object_Highest_Salary
{
    internal class Program
    {
        class Employe
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            public void data(int Id,string Name,int Salary)
            {
                this.Id = Id;
                this.Name = Name;
                this.Salary = Salary;
            }
            public void display()
            {
                Console.WriteLine("Employe Id: " + Id);
                Console.WriteLine("Employe Name: " + Name);
                Console.WriteLine("Employe Salary: " + Salary);

            }
          
        }

        static void Main(string[] args)
        {
            Employe [] emp = new Employe[3];
            emp [0] = new Employe();
            emp[1] = new Employe();
            emp[2] = new Employe();

            for(int cnt=0;cnt<3;cnt++)
            {
                Console.WriteLine("Enter Id:");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Salary:");
                int Salary = Convert.ToInt32(Console.ReadLine());
                emp[cnt].data(Id, Name, Salary);
            }
           
            for(int cnt=0;cnt<3;cnt++)
            {
                emp[cnt].display();
            }
            int high = emp[0].Salary;
            int foundat=0;
            for (int cnt = 1; cnt < 3; cnt++)
            {
                if (high < emp[cnt].Salary)
                {
                    high = emp[cnt].Salary;
                    foundat = cnt;
                }
            }
            Console.WriteLine("-----Highest salary-------");
            Console.WriteLine("Employe Id: " + emp[foundat].Id);
            Console.WriteLine("Employe Name: " + emp[foundat].Name);
            Console.WriteLine("Employe Salary: " + emp[foundat].Salary);


            Console.ReadKey();
        }
    }
}
