using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfelseEligibleAdmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int phy, che, maths, total;
            float per;
            string grade;
            Console.Write("Enter physics :");
            phy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter chemistry :");
            che = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Maths :");
            maths = Convert.ToInt32(Console.ReadLine());

            total = phy + che + maths;
            Console.WriteLine("Total Marks" + total);
            

            if (phy>=55 && che>=50 && maths>=65)
            {
                Console.WriteLine("The Candidate is eligible for admission");                                              
            }
            else 
            {
                Console.WriteLine("The Candidate it is not eligible for admission");
            }
            Console.ReadLine();

        }
    }
}
