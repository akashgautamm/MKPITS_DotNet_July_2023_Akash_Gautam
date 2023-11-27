using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopCubeUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cube;
            int count;
            Console.WriteLine("Enter num:");
            num = Convert.ToInt32(Console.ReadLine());

            for(count=1;count<=num;count++)
            {
                cube = count * count * count;
                Console.WriteLine("Number is : {0} and cube of the {1} is :{2}", count, count, cube);
            }
            Console.ReadKey();
        }
    }
}
