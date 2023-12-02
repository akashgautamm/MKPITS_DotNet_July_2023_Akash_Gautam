using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfelseWeakName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weak;
            Console.WriteLine("Enter A");
            weak =Convert.ToInt32(Console.ReadLine());

            if (weak == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (weak == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (weak == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (weak == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (weak == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (weak == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (weak == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Invalid Days");
            }
            Console.ReadKey();
        }
    }
}
