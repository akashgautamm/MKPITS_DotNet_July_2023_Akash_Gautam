using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Copy_Book
{
    internal class Program
    {
        class Book
        {
            int Id;
            String Name;
            String Author;
            public Book()
            {
                Id = 123;
                Name = "John";
                Author = "Japnise";
            }
            public Book(Book b2)
            {
                Id = b2.Id;
                Name = b2.Name;
                Author = b2.Author;
            }
            public void display()
            {
                Console.WriteLine("Book Id: " + Id);
                Console.WriteLine("Book Name: " + Name);
                Console.WriteLine("Book Author: " + Author);


            }

        }
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Book b2 = new Book(b1);
            Console.WriteLine("Book 1 Details are:");
            b1.display();
            Console.WriteLine("Book 2 Details are:");
            b2.display();
            Console.ReadKey();

        }
    }
}
