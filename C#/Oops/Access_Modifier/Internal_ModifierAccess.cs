using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal_ModifierAccess
{
    class Internal
    {
        internal string name = "Yash";
        internal void data(string mess)
        {
            Console.WriteLine("Message: " + mess);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Internal i = new Internal();
            Console.WriteLine("Name :" + i.name);
            i.data("Hello");
            Console.ReadKey();
        }
    }
}
