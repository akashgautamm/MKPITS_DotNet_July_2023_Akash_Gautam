using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_Capacity_Count_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(11);
            a.Add(12);
            a.Add(13);
            a.Add(14);
            a.Add(26);
            foreach(Object o in a)
            {
                Console.WriteLine("Numbers: " + o);
            }
            Console.WriteLine("Capacity: " + a.Capacity);
            Console.WriteLine("Count: " + a.Count);
            Console.ReadKey();
        }
    }
}
