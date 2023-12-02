using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Enqueue_Dequeue
{
    class Customer
    {
        public int id;
        public string name;
        public int no;
        public Customer(int id, string name,int no) 
        {
            this.id = id;
            this.name = name;   
            this.no = no;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q=new Queue();
            Customer c1 = new Customer(1, "Amit", 9909);
            Customer c2 = new Customer(2, "Lal", 96559);
            Customer c3 = new Customer(3, "Avinash", 9955);
            q.Enqueue(c1);
            q.Enqueue(c2);
            q.Enqueue(c3);
            foreach(Customer c in q)
            {
                Console.WriteLine("Id: "+c.id+" Name: "+c.name+" Number: "+c.no);

            }
            Console.WriteLine("-------------After Dequeue-------------");
            q.Dequeue();
            foreach(Customer c in q)
            {
                Console.WriteLine("Id: " + c.id + " Name: " + c.name + " Number: " + c.no);
            }
            Console.ReadKey();
        }
    }
}
