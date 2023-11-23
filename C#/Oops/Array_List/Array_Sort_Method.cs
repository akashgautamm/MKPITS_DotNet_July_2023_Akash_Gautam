using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_Sort_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(100);
            ar.Add(90);
            ar.Add(80);
            ar.Add(70);
            Console.WriteLine("Without Sort Method");
            foreach (object o in ar)
            {
                Console.WriteLine("Numbers: " + o);
            }
            ar.Sort();
            Console.WriteLine("Array Sorting");
            foreach(object o in ar)
            {
                Console.WriteLine("Numbers: " + o);
            }
            Console.ReadKey();
        }
    }
}
