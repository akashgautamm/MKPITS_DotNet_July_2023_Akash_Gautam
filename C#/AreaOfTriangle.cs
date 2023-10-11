using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Of_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length, breath,area;
            Console.WriteLine("Enter Length");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Breth");
            breath = Convert.ToInt32(Console.ReadLine());

            area= length * breath;
            Console.WriteLine("Area is " + area);
            Console.ReadKey();


        }
    }
}
