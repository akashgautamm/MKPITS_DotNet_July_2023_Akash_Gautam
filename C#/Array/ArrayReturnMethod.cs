using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReturnMethod
{
    internal class Program
    {
        static int[] arrreturn()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            return arr;
        }
        static void Main(string[] args)
        {
            int[] res = arrreturn();
            for(int cnt=0;cnt<5;cnt++)
            {
                Console.WriteLine(res[cnt]);
            }
            Console.ReadKey();
        }
    }
}
