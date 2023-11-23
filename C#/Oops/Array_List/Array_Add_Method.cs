using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_Add_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add("Akash");
            a.Add("Lucky");
            a.Add("Sarang");
            a.Add("Chetan");

            foreach (Object aa in a)
            {
                Console.WriteLine("Student Name: " + aa);
            }
            Console.ReadKey();
        }
    }
}
