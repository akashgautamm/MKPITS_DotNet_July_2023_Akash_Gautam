using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor2_Parameter_Product
{
    internal class Program
    {
        class Product
        {
            string Name;
            int Id;
            int Price;
            int Quantity;
            public Product()
            {
                Name = "Rice";
                Id = 1;
                Price = 250;
                Quantity = 50;
            }
            public Product(string Name,int Id,int Price,int Quantity)
            {
                this.Name = Name;
                this.Id = Id;
                this.Price = Price;
                this.Quantity = Quantity;

            }
            public void display()
            {
                Console.WriteLine("Product Name:" + Name);
                Console.WriteLine("Product Id:" + Id);
                Console.WriteLine("Product Price:" + Price);
                Console.WriteLine("Product Quantity:" + Quantity);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Product Id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Price:");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());




            Product p = new Product();
            p.display();
            Product p2 = new Product(name,id,price,quantity);
            p2.display();
            Console.ReadKey();
        }
    }
}
