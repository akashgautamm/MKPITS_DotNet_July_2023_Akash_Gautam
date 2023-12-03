using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Calulator
    {
        public int n1;
        public int n2;
        public int result = 0;
       
        public void Add(int n1,int n2)
        {
             result = n1 + n2;
           
        }
        public  void Sub(int n1, int n2)
        {
             result = n1 - n2;
           
        }
        public void Div(int n1, int n2)
        {
             result = n1 / n2;
           
        }
        public void Mul(int n1, int n2)
        {
             result = n1 * n2;
           
        }
        public void display()
        {
            Console.WriteLine("Result is: " + result);
            

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calulator c = new Calulator();
            while (true)
            {
               
                try
                {
                    Console.WriteLine("Enter Num1");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Num2");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Operator");
                    string op = Console.ReadLine();

                    if (op == "+")
                    {
                        c.Add(num1, num2);
                        
                    }
                    else if (op == "-")
                    {
                        c.Sub(num1, num2);
                     
                    }
                    else if (op == "/")
                    {
                        c.Div(num1, num2);

                    }
                    else if (op == "*")
                    {
                        c.Mul(num1, num2);
                       
                    }
                    else
                    {
                        Console.WriteLine("Invalid Operator");
                       
                    }
                    c.display();
                    break;
                    
                }
                catch (DivideByZeroException dd)
                {
                    Console.WriteLine("Does not divide");
                    Console.WriteLine(dd.ToString());0
                }
                catch (Exception e) 
                {
                    Console.WriteLine("Does not allow string");
                    Console.WriteLine(e.ToString());
                    
                }
              
            }
            Console.ReadKey();


        }
    }
}
