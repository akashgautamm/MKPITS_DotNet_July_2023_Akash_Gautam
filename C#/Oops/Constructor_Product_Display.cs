using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorProductDisplay
{
    class Product
    {
        int Id;
        string Name;
        int Price, Quantity;
        public Product()
        {
            Id = 123;
            Name = "Tomato sos";
            Price = 200;
            Quantity = 2;
        }
        public void display()
        {
            Console.WriteLine("Product Id: " + Id);
            Console.WriteLine("Product Name: " + Name);
            Console.WriteLine("Product Price: " + Price);
            Console.WriteLine("Product Quantity: " + Quantity);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.display();
            Console.ReadKey();
        }
    }
}
