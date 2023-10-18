using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DowhileCube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int count = 1;
            int cube;
            Console.WriteLine("Enter Num:");
            num = Convert.ToInt32(Console.ReadLine());
            do
            { 

                cube = count * count * count;
                Console.WriteLine("Number is : {0} and cube of the {1} is :{2}", count, count, cube);
                count++;
            }
            while (count <= num);
            Console.ReadKey();
        }
    }
}
