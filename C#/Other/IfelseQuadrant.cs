using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseQuadrant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter x");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter x");
            y = Convert.ToInt32(Console.ReadLine());

            if(x>0 && y>0)
            {
                Console.WriteLine("The Coordinate point ({0},{1}) Ii is first quadrant",x,y);
            }
            else if(x<0 && y>0)
            {
                Console.WriteLine("The Coordinate point ({0},{1}) Ii is second quadrant", x, y);
            }
            else if(x<0 && y<0)
            {
                Console.WriteLine("The Coordinate point ({0},{1}) Ii is third quadrant", x, y);
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The Coordinate point ({0},{1}) Ii is fourth quadrant", x, y);
            }

            Console.ReadKey();


        }

    }
    
}
