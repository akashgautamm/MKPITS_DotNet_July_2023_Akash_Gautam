using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_RemoveAt_Method
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
            Console.WriteLine("Removing  12");
            a.Remove(12);
            foreach(object o in a)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("Removing at array");
            a.RemoveAt(2);
            foreach (object o in a)
            {
                Console.WriteLine(o);
            }
            Console.ReadKey();
        }
    }
}
