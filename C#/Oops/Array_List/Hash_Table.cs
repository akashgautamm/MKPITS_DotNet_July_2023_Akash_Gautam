using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hash_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "Akash");
            ht.Add("2", "Sarang");
            ht.Add("3", "Chetan");

            if (ht.ContainsValue("Sujit"))
                Console.WriteLine("Already Exists");
            else
                ht.Add("4", "Sujit");
            ICollection key = ht.Keys;
            foreach (string s in key)
                Console.WriteLine(s + ":" + ht[s]);
            Console.ReadKey();
        }
    }
}
