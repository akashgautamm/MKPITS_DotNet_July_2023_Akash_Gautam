using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchChoiceShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice,l,b,area,num,square;
            float r,circle;
            Console.WriteLine("1.Circle\n2.Rectangle\n3.Square");
            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter Radius:");
                    r= Convert.ToSingle(Console.ReadLine());

                    circle = 3.14f * r * r;
                    Console.WriteLine("Circle is ={0}", circle);
                    break;

                case 2:
                    Console.WriteLine("Enter Length:");
                    l = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Breadth:");
                    b = Convert.ToInt32(Console.ReadLine());

                    area = l * b;
                    Console.WriteLine("Area is ={0}", area);
                    break;
                case 3:
                    Console.WriteLine("Enter Num:");
                    num= Convert.ToInt32(Console.ReadLine());

                    square = num * num;
                    Console.WriteLine("Square is ={0}", square);
                    break;

            }
            Console.ReadKey();

        }
    }
}
