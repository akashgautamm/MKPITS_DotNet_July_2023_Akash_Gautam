using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List
{
    internal class Program
    {
        static List<string> li = new List<string>();
        static void Main(string[] args)
        {
          
            li.Add("Akash");
            li.Add("Devid");
            li.Add("Sarang");
            li.Add("Chetan");
            li.Add("Lucky");
            foreach (string s in li)
                Console.WriteLine(s);
            Console.WriteLine("------------------------");
            Console.WriteLine("Is Available");
            Console.WriteLine(li.Contains("Jayant"));  //Check in list ,if true or else false...

            li.Remove("Chetan");
            Console.WriteLine("------------------------");
            Console.WriteLine("After Removing");
            foreach (string s in li)
                Console.WriteLine(s);
            Console.WriteLine("------------------------");
            Console.WriteLine("After Insert");
            li.Insert(3, "Sujit");
            foreach (string s in li) 
            Console.WriteLine(s);
            Console.WriteLine("------------------------");
            Console.WriteLine("After Sort");
            li.Sort();
            foreach (string s in li)
                Console.WriteLine(s);
            Console.ReadKey(); 

        }
       
    }
}
