using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Memory_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Akash";
            string subject = "Javascript";
            Console.WriteLine("Name: " + name.Length);
            StringBuilder sb = new StringBuilder(name.Length,name.Length);
            try
            {
                sb.Append(subject);
            }
            catch(Exception ee)
            {
                Console.WriteLine("Error" + ee.ToString());
            }

            
            Console.ReadKey();
        }
    }
}
