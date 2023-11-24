using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sorted_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add("5", "Akash");
            s.Add("7", "Neha");
            s.Add("6", "Ajinkya");
            s.Add("9", "Santosh");

            ICollection key = s.Keys;
            foreach(string st in key)
            {
                Console.WriteLine(st + "" + s[st]);
            }
            Console.ReadKey();
        }
    }
}
