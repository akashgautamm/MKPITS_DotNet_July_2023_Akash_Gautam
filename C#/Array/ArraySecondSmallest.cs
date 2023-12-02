using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySecondLargest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int min1, min2;
            for (int cnt = 0; cnt < 5; cnt++)
            {
                arr[cnt] = Convert.ToInt32(Console.ReadLine());
            }
            min1 = min2 = arr[0];
            for (int cnt = 0; cnt < 5; cnt++)
            {
                if (arr[cnt] < min1)
                {
                    min2 = min1;
                    min1 = arr[cnt];
                }
                else if (arr[cnt] < min2)
                {
                    min2 = arr[cnt];
                }
            }
            Console.WriteLine("First minimum is " + min1);
            Console.WriteLine("Second minimum is " + min2);

            Console.ReadKey();
        }
    }
}
