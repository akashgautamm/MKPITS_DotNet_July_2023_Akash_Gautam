using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overload_Book4Parameter
{
    internal class Program
    {
        class Book
        {
            int Price;
            string Name;
            string Title;
            string Author;
            public void getdata()
            {
                Price = 250;
                Name = "John";
                Title = "Jungle Book";
                Author = "Rest";
            }
            public void getdata(int price)
            {
                this.Price = price;
            }
            public void getdata(int price,string name)
            {
                this.Price = price;
                this.Name = name;
            }
            public void getdata(int price, string name,string title)
            {
                this.Price = price;
                this.Name = name;
                this.Title = title;
            }
            public void getdata(int price, string name, string title,string author)
            {
                this.Price = price;
                this.Name = name;
                this.Title = title;
                this.Author = author;
            }
            public void display()
            {
                Console.WriteLine("Book Price: " + Price);
                Console.WriteLine("Book Name: " + Name);
                Console.WriteLine("Book Title: " + Title);
                Console.WriteLine("Book Author: " + Author);
            }
        }
        static void Main(string[] args)
        {
            Book book0 = new Book();
            book0.getdata();
            book0.display();
            Book book1 = new Book();
            book1.getdata(100);
            book1.display();
            Book book2=new Book();
            book2.getdata(200, "John");
            book2.display();
            Book book3 = new Book();
            book3.getdata(200, "John","Magic Book");
            book3.display();
            Book book4 = new Book();
            book4.getdata(200, "John", "Magic Book","Vishal");
            book4.display();

            Console.ReadKey();

        }
    }
}
