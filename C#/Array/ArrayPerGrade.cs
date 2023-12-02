using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPerGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sub = new int[5];
            int i;
            float per;
            int total = 0;
            for(i=0;i<5;i++)
            {
                Console.WriteLine("Enter Sub Marks");
                sub[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(i=0;i<5; i++) 
            {
                total = total + sub[i];
                Console.WriteLine("Sub [{0}]={1}", i + 1, sub[i]);
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" Total Marks is " + total);
            per = total / 500f * 100f;
            Console.WriteLine(" Percent is " + per);
            if(per>=75)
            {
                Console.WriteLine(" Grade is Topper");
            }
            else if (per >= 60 && per<75)
            {
                Console.WriteLine(" Grade is Second");
            }
            else if (per >= 40 && per < 60)
            {
                Console.WriteLine(" Grade is Third");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.ReadKey();
        }
    }
}
