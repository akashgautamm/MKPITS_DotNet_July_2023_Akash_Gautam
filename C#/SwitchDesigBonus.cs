using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDesigBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string desig;
            int bonus=0;
            Console.WriteLine("Enter Designation");
            desig = Console.ReadLine();

            switch(desig)
            {
                case "manager":
                    bonus = 5000;
                    break;
                case "clerk":
                    bonus = 3000;
                    break;
                case "peon":
                    bonus = 1000;
                    break;
                defalut:
                    Console.WriteLine("Invalid Designation");
                    break;
            }
            Console.WriteLine("Bonus ={0}", bonus);
            Console.ReadKey();
        }
    }
}
