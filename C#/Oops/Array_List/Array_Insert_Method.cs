using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Array_Insert_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(2);
            a.Add(3);
            a.Add(5);
            a.Insert(2, 10);
            foreach(Object o in a)
            {
                Console.WriteLine("Numbers: "+o);
            }
            Console.ReadKey();
        }
    }
}
