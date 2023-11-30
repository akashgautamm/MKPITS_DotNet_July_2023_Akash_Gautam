using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_Cast_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Amit");
            sb.Append("Shreya");
            Console.WriteLine("sb="+sb.ToString());
            Object ob = sb;
            Console.WriteLine("Ob="+ob.ToString());
            try
            {
                System.IO.StreamReader ss = (System.IO.StreamReader)ob;
            }
            catch(InvalidCastException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.ReadKey();
        }
    }
}
