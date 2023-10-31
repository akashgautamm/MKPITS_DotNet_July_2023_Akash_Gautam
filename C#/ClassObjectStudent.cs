using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectStudent
{
    internal class Program
    {
        class Student
        {
            int rno;
            string name;
            int[] mark;
            public void getdata(string name,int rno,int[]mark)
            {
                this.name = name;
                this.rno = rno;
                this.mark = mark;
                

            }
            public void getdisplay()
            {
                Console.WriteLine("Student Name :" + name);
                Console.WriteLine("Student Roll No :" + rno);
                int total = 0;
                for(int cnt=0;cnt<5;cnt++)
                {
                    total = total + mark[cnt];
                }
                int avg = total / 5;
                Console.WriteLine("Total Mark :" + total);
                Console.WriteLine("Average is  :" + avg);
                

            }


           

        }
        static void Main(string[] args)
        {
            Student s1= new Student();
            
         
            Console.WriteLine("Enter Name :");
            string name=Console.ReadLine();

            Console.WriteLine("Enter RollNo :");
            int rno = Convert.ToInt32(Console.ReadLine());

            int[] mark = new int[5];
            Console.WriteLine("Enter 5 Subject Mark");

            for (int cnt=0;cnt<5;cnt++)
            {
                mark[cnt] = Convert.ToInt32(Console.ReadLine());
                 
            }
           
            s1.getdata(name, rno,mark);
            s1.getdisplay();
            Console.ReadKey();
        }
    }
}
