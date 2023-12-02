using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List_Push_Pop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            foreach (int i in stack) 
                Console.WriteLine(i);
            Console.WriteLine("--------------------");
            stack.Pop();
            stack.Pop();
            foreach (int i in stack)
                Console.WriteLine(i);
            Console.WriteLine("--------------------");

            Console.ReadKey();

        }
    }
}
