using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Static_Main
{
    class Book
    {
        public static int bookid;
        public static string name;
        public static void display()
        {
            Console.WriteLine("Hello");
        }
     }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book.bookid = 1;
            Book.name= "Hello";
            Console.WriteLine("Id and Name: "+Book.bookid+Book.name);
            Book.display();
            Program p= new Program();
            p.Main();
            Console.ReadKey();
           


        }
        public void Main()
        {
            Console.WriteLine("Hello From Main Method");
        }
    }
}
