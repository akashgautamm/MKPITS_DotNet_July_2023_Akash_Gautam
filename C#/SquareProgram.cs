using System;


namespace SquareProgram
{
    internal class Square
    {
        static void Main(string[] args)
        {
            int num, square;
            Console.WriteLine("Enter num");
            num = Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("Square is " + square);
            Console.ReadKey();


        }
    }
}
