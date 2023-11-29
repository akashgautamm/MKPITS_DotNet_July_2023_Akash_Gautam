using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Throw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
           try
           {
                Console.WriteLine("Enter Age");
                age = Convert.ToInt32(Console.ReadLine());
                if(age<18)
                {
                    Console.WriteLine("Enter Age eual to 18 or greater");
                }
           }
           catch(OverflowException ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("Enter small a number please");
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("Enter age 18 or greater than 18");
                age = Convert.ToInt32(Console.ReadLine());

            }
            finally
            {
                Console.WriteLine("Finally block is executing");
                Console.WriteLine("Age: " + age);
            }
            Console.ReadKey();
            
        }
    }
}
