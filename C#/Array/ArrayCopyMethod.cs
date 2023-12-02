using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopyMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr1 = new int[5];
            Array.Copy(arr, arr1, 5);
            for(int cnt=0;cnt<arr1.Length;cnt++)
            {
                Console.WriteLine(arr1[cnt]);
            }
            Console.ReadKey();
        }
    }
}
