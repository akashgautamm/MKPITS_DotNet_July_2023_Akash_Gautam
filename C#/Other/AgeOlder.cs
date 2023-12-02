using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOlder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter Age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than " + age);
            Console.ReadKey();
        }
    }
}
