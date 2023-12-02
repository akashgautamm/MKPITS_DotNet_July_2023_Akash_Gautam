using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfelseHeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cm;
            Console.WriteLine("Enter Height with cm");
            cm = Convert.ToInt32(Console.ReadLine());

            if(cm<150)
            {
                Console.WriteLine("It is Short");
            }
            else if(cm>150 && cm<165)
            {
                Console.WriteLine("Average Height");
            }
            else
            {
                Console.WriteLine("Abnormal height");
            }
            Console.ReadKey();
        }
    }
}
