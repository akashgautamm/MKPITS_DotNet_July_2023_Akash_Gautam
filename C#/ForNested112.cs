using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForNested123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row;
            int col;
            for (row = 1; row <= 3; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write(row+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
