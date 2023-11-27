using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Last_First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> li = new LinkedList<int>();
            li.AddLast(1);
            li.AddLast(2);
            li.AddLast(3);
            li.AddFirst(4);

            LinkedListNode<int> node = li.Find(2);
            li.AddAfter(node, 5);

            foreach(int i in li)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
