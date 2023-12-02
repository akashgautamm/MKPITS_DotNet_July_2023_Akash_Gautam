using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Static_Intrest
{
    class Book
    {
        public int id;
        public string name;
        public static float intrest = 8.8f;
        public Book(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("Book Id " + id);
            Console.WriteLine("Book Name " + name);
            Console.WriteLine("Book float " + intrest);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book(123, "Akash");
            Book b2 = new Book(456, "Lucky");
                b1.display();
            b2.display();
            Console.ReadKey();
        }
    }
}
