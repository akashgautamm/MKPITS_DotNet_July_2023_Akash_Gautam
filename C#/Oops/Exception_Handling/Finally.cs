﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            try
            {
                res = num1 / num2;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Cannot be  divide zero");
            }
            finally
            {
                Console.WriteLine("res: " + res);
                Console.WriteLine("Bye");
            }
            Console.ReadKey();
        }
    }
}
