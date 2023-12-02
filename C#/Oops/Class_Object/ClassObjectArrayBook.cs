using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjArrayBook
{
    internal class Program
    {
        class Book
        {
            string title,author;
            int year;

            public void getdata(string title, string author, int year)
            {
                this.title = title;
                this.author = author;
                this.year = year;
            }
            public void getdisplay()
            {
                Console.WriteLine("Book Title :" + title);
                Console.WriteLine("Book Author :" + author);
                Console.WriteLine("Book year :" + year);

            }
           
        }
        static void Main(string[] args)
        {
            Book[] bookied = new Book[3];
            bookied[0] = new Book();
            bookied[1] = new Book();
            bookied[2] = new Book();
            for (int cnt=0;cnt<3;cnt++)
            {
                Console.WriteLine("Enter Title :");
                string title = Console.ReadLine();
                Console.WriteLine("Enter Author :");
                string author = Console.ReadLine();
                Console.WriteLine("Enter Year :");
                int year= Convert.ToInt32(Console.ReadLine());
                bookied[cnt].getdata(title,author,year);


            }
            for(int cnt=0;cnt<3;cnt++)
            {
                bookied[cnt].getdisplay();
            }
            Console.ReadKey();

        }
    }
}
