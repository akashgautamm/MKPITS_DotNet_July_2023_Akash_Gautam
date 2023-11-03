using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorParaBook
{
    internal class Program
    {
        class Book
        {
            int Id;
            string Title,Author;
            int Price;
            public Book(int Id,String Title,String Author,int Price)
            {
                this.Id = Id;
                this.Title = Title;
                this.Author = Author;
                this.Price = Price;
            }
            public void display()
            {
                Console.WriteLine("Book Id: " + Id);
                Console.WriteLine("Book Title: " + Title);
                Console.WriteLine("Book Author: " + Author);
                Console.WriteLine("Book Price: " + Price);
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Book Id:");
            int id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter Autor:");
            string author = Console.ReadLine();

            Console.WriteLine("Enter Price:");
            int price= Convert.ToInt32(Console.ReadLine());

            Book b=new Book(id,title,author,price);
            b.display();
            Console.ReadKey();

        }
    }
}
