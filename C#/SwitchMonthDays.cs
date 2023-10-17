using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchMonthDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Month Num:");
            num = Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 1:
                case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                    Console.WriteLine("This Month have 31 days");
                    break;
                    case 2:
                    Console.WriteLine("This month have 28 or 29 days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("This month have  30 days");
                    break;
                default:
                    Console.WriteLine("Invalid Months");
                    break;

                    
            }
            Console.ReadKey();
        }
    }
}
