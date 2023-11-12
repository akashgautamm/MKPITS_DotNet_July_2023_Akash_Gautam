using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Maths
{
    class Maths
    {
        public static float p=3.14f;
        public static int cube(int n)
        {
            return n * n * n;
        }
             
     }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value of PI is: " + Maths.p);
            Console.WriteLine("Cube of 3 is: " + Maths.cube(3));
            Console.ReadKey();

        }
    }
}
