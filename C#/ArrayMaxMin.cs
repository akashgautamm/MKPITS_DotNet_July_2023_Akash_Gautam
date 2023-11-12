using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMax_Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int max = 0;
            int min = 0;
            for (int cnt=0;cnt<5;cnt++)
            {
                arr[cnt] = Convert.ToInt32(Console.ReadLine());
            }
            max = arr[0];
            for(int cnt=1;cnt<5;cnt++)
            {
                if (arr[cnt]>max)
                {
                    max = arr[cnt];

                }
            }
            min = arr[0];
            for (int cnt = 0; cnt < 5; cnt++)
            {
                if (arr[cnt]<min)
                {
                    min= arr[cnt];
                }
            }
            Console.WriteLine("Maximum is " + max);
            Console.WriteLine("Mainimum is " + min);
            Console.ReadKey();
        }
    }
}
