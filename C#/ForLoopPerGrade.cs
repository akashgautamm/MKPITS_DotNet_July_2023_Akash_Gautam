using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopPerGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sub;
            int total = 0;
            float per = 0;
            int count;
            string grade;
            for(count=1;count<=5;count++)
            {
                Console.WriteLine("Enter Subject Marks:");
                sub=Convert.ToInt32(Console.ReadLine());
                
                total = total+sub;

                per = total / 500.0f * 100.0f;

                

            }
            Console.ReadLine();
            if (per >= 80)
            {
                grade = "Topper";
            }
            else if (per < 80 && per >= 60)
            {
                grade = "Second";
            }
            else if (per < 60 && per >= 40)
            {
                grade = "Third";

            }
            else
            {
                grade = "Fail";
            }
            Console.WriteLine("Total marks {0}", total);
            Console.WriteLine("Percent {0}", per);

            Console.WriteLine("Grade is :{0}", grade); 
            Console.ReadKey();
        }
    }
}
