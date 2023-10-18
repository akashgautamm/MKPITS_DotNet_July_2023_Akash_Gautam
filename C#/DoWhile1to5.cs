using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile1to5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int counter = 1;
            do
            {
                Console.WriteLine(counter);
                counter++;
            }
            while (counter <= 5);
            Console.ReadKey();
        }
    }
}
