using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectRectangle
{

    internal class Program
    {
        class Rectangle
        {
            int width, height;
            public void getdata(int width,int height)
            {
                this.width = width;
                this.height = height;
                

            }
            public void getdisplay()

            {
                int rect = width * height;
                Console.WriteLine("Rectangle is " + rect);
            }



            
        }
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Console.WriteLine("Enter Width & Height");
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            r1.getdata(width,height);
            r1.getdisplay();
            Console.ReadKey();
            

        }
    }
}
