﻿using System;

namespace Divide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, div;
            Console.WriteLine("Enter num1");
            num1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2=Convert.ToInt32(Console.ReadLine());
            div = num1 / num2;
            Console.WriteLine("Div is " + div);
            Console.ReadKey();
        }
    }
}
