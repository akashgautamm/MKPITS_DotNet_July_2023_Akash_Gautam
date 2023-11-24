using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack_Push_Pop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push('A');
            s.Push('B');
            s.Push('C'); 
            s.Push('D');
            Console.WriteLine("Current Stack");
            foreach (char c in s)
                Console.WriteLine(c);
            s.Push('E');
            s.Push('F');
            Console.WriteLine("The Next Popable:"+s.Peek());
            Console.WriteLine("Current Stack");
            foreach (char c in s)
                Console.WriteLine(c);
            s.Pop();
            s.Pop();
            s.Pop();
            Console.WriteLine("Current Stack");
            foreach (char c in s)
                Console.WriteLine(c);
            Console.ReadKey();




        }
    }
}
