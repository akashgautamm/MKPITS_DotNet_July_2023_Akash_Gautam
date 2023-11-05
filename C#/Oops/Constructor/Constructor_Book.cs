using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorBookLibrary
{
    internal class Program
    {
        class Book
        {


            int Bookid;
            string Title, Author;
            int price;
            public Book()
            {
                Bookid = 1;
                Title = "Jameson";
                Author = "Anderson";
                price = 250;
            }
            public void display()
            {
                Console.WriteLine("Book Id: " + Bookid);
                Console.WriteLine("Book Title: " + Title);
                Console.WriteLine("Book Author: " + Author);
                Console.WriteLine("Book Price: " + price);
            }
        }
        static void Main(string[] args)
        {
            Book b = new Book();
            b.display();
            Console.ReadKey();
        }
    }
}
