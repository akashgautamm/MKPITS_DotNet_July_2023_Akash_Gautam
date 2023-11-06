using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overload_Callingone_method_Anothermethod
{
    internal class Program
    {
        class Book
        {
            int number;
            string Name;
            
            public void getdata(int number)
            {
                getdata(number, "Akash");
            }
            public void getdata(int number, string name)
            {
                this.number = number;
                this.Name = name;
            }
            public void display()
            {
                Console.WriteLine("Number: " + number);
                Console.WriteLine("Name: " + Name);
            }

        }
        static void Main(string[] args)
        {
            Book book = new Book();
            book.getdata(123);
            book.display();
            Console.ReadKey();
        }
    }
}
