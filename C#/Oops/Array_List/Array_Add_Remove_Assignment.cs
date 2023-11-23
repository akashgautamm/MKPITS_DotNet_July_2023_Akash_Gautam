using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Add_Remove_assi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(40);
            a.Add(10);
            a.Add(30);
            a.Add(50);
            Console.WriteLine("Array");
            foreach (Object o in a)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("Removing Array 2");
            a.RemoveAt(2);
            foreach(Object o in a)
            {
                Console.WriteLine(o);
            }
            Console.ReadKey();
        }
    }
}
