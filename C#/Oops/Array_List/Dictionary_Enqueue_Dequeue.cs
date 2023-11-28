using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List_Enqueue_Dequeue
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Queue<string> q=new Queue<string>();
            q.Enqueue("Hello");
            q.Enqueue("Hii");
            q.Enqueue("Hey");
            q.Enqueue("Welcome");

            foreach (string s in q)
                Console.WriteLine(s);
            Console.WriteLine("-------------------");
            q.Dequeue();
            foreach(string s in q)
                Console.WriteLine(s);
            Console.WriteLine("-------------------");
            Console.WriteLine(q.Peek());
            
            foreach (string s in q)
                Console.WriteLine(s);
            Console.WriteLine("-------------------");
            Console.ReadKey();
        }
    }
}
