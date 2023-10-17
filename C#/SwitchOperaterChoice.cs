using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchOperaterChoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, add,mul,div,sub, choice;

            Console.WriteLine("1.Addition\n2.Multiply\n3.Substraact\n4.Divide\n5.Exit");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Num 1:");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Num 1:");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    add = n1 + n2;
                    Console.WriteLine("Addition  is ={0}", add);
                    break;
                case 2:
                    Console.WriteLine("Enter Num 1:");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Num 1:");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    mul = n1 * n2;
                    Console.WriteLine("Multiply  is ={0}", mul);
                    break;
                case 3:
                    Console.WriteLine("Enter Num 1:");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Num 1:");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    sub = n1 - n2;
                    Console.WriteLine("Substract  is ={0}", sub);
                    break;
                case 4:
                    Console.WriteLine("Enter Num 1:");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Num 1:");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    div = n1 / n2;
                    Console.WriteLine("Division  is ={0}", div);
                    break;
                case 5:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Invalid ");
                    break;



            }
            Console.ReadKey();
        }
    }
}
