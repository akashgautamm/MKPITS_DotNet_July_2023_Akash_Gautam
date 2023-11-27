using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Linked_List
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("a", "Akash");
            d.Add("b", "Boy");
            d.Add("c", "Chetan");
            d.Add("d", "David");
            Console.WriteLine("Dictionary has {0}" , d.Count);
            Console.WriteLine("---------------------");
            List<string> li = new List<string>(d.Keys);
            foreach(string s in li)
            {
                Console.WriteLine("Keys: "+s);

            }
            Console.WriteLine("---------------------");
            List<string> v = new List<string>(d.Values);
            foreach(string s in v)
            {
                Console.WriteLine("Values: " + s);
            }
            Console.WriteLine("---------------------");
            foreach(KeyValuePair<string,string>s in d )
            {
                Console.WriteLine("Keys: {0}  Values: {1}", s.Key, s.Value);
            }
            Console.ReadKey();
        }
       
    }
}
