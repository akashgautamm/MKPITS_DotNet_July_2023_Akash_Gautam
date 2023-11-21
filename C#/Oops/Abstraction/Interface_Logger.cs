using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Logger
{
    interface  Logger
    {
        void logmessage();
        void logerror();
    }
    class  ConsoleLogger:Logger
    {
        public void logmessage()
        {
            Console.WriteLine("Message Show......");

        }
        public void logerror()
        {
            Console.WriteLine("Message Error......");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger l = new ConsoleLogger();
            l.logmessage();
            l.logerror();
            Console.ReadKey();
        }
    }
}
