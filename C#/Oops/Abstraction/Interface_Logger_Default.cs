using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Logger_Default
{
    interface Logger
    {
        void Loginfo();
    }
    class Consolelogger:Logger
    {
        public void Loginfo()
        {
            Console.WriteLine("Message info");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger l = new Consolelogger();
            l.Loginfo();
            Console.ReadKey();
        }
    }
}
