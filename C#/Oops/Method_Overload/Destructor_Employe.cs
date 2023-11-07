using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor_Employe
{
    internal class Program
    {
        class Employe
        {
            public Employe()
            {
                Console.WriteLine("Constructor Called");
            }
            ~Employe()
            {
                Console.WriteLine("Destructor Called");
            }
        }
        static void Main(string[] args)
        {
            Employe emp = new Employe();
            Console.ReadKey();
            Employe emp1 = new Employe();
            Console.ReadKey();
        }
    }
}
