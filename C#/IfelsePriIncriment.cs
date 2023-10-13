using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreIncrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = ++i;
            Console.WriteLine("Value of i:" + i + "\n Value of j:" + j);
            Console.ReadKey();
        }
    }
}
