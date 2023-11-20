using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object_Example
{
    internal class Program
    {
        class Mobile
        {
            public int ModelNo;
            public string ModelName;
            public void getdata(int ModelNo,string ModelName)
            {
                this.ModelNo = ModelNo;
                this.ModelName = ModelName;
            }
            public void display()
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Model Number: " + ModelNo);
                Console.WriteLine("Mobile Name: " + ModelName);
            }
        }
        static void Main(string[] args)
        {
            Mobile m = new Mobile();
            Console.WriteLine("Enter Model Number: ");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mobile Number: ");
            string name = Console.ReadLine();

            m.getdata(no,name);
            m.display();
            Console.ReadKey();
        }
    }
}
