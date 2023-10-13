using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfelseBonusSalDesigntion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eno, bsal;
            float totalsal;
            string ename;
            string desig;
            float bonus=0;
            Console.WriteLine("Enter employe num");
            eno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter employe name");
            ename = Console.ReadLine();

            Console.WriteLine("Enter basic sal");
            bsal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Designation (Manager,Clerk,Peon)");
            desig = Console.ReadLine();

            if(desig == "Manager")
            {
                bonus = bsal * 0.55f;
            }
            else if (desig == "Clerk")
            {
                bonus = bsal * 0.25f;
            }
            else if(desig == "Peon")
            {
                bonus = bsal * 0.10f;

            }
            else
            {
                Console.WriteLine("Invalid Designation");
            }
            Console.WriteLine("Emp num: {0}, Emp Name :{1},Emp Sal :{2}, Designation :{3}", eno, ename, bsal, desig);

            totalsal = bsal + bonus;
            Console.WriteLine("Total sal: {0},Bonus: {1}",totalsal,bonus);

            Console.ReadKey();

        }
    }
}
