﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseVote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter Age");
            age=Convert.ToInt32(Console.ReadLine());    

            if(age > 18) 
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("It is not eligible");
            }
            Console.ReadKey();
        }
    }
}
