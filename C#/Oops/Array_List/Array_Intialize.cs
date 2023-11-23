using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_Intialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(10);
            ar.Add(20);
            ar.Add(30);
            foreach(Object o in ar)
            {
                Console.WriteLine("Number" + o);
            }
            Console.ReadKey();
        }
    }
}
