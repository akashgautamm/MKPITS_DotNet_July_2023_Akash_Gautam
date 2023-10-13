using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfelseTrain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string origin;
            int date;
            int train;
            string sclass;
            string pname;
            string dest;
            int km;
            Console.WriteLine("Passenger Name");
            pname= Console.ReadLine();

            Console.WriteLine("Enter Date");
            date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Train Num");
            train = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Seat No");
            sclass = Console.ReadLine();

            Console.WriteLine("Enter Origin");
            origin = Console.ReadLine();

            Console.WriteLine("Enter Destination");
            dest = Console.ReadLine();

            Console.WriteLine("Enter Kilometer");
            km =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Passenger Name: {0}\n Enter date: {1}\n Enter Train num: {2}\n  Seat Num: {3}\n  Enter Origin: {4}\n Enter Destination: {5}\n Enter kilometer: {6}\n", pname, date, train, sclass, origin, dest, km);



            if (km<100)
            {
                Console.WriteLine("Total fare is 100 rs");
            }
            else if (km>=100 && km<=500)
            {
                Console.WriteLine("Total fare is 200 rs ");
            }
            else if (km > 500)
            {
                Console.WriteLine("Total fare is 500 rs ");
            }

            
            
            Console.ReadKey();

  













        }
    }
}
