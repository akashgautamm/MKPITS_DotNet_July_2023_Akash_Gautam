using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue('A');
            q.Enqueue('B');
            q.Enqueue('C');
            q.Enqueue('D');
            Console.WriteLine("Current Enqueue");
            foreach(char c in q)
                Console.WriteLine(c);
            Console.WriteLine("Removing Some Value");
            char ch = (char)q.Dequeue();
             ch = (char)q.Dequeue();
            Console.WriteLine(ch);
            Console.WriteLine("After Dequeue");
            foreach (char c in q)
                Console.WriteLine(c);
            Console.ReadKey();




        }
    }
}
