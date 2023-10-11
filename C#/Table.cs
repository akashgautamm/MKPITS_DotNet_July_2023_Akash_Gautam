using System;


namespace Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum,count;
            Console.WriteLine("Enter Num");
            num = Convert.ToInt32(Console.ReadLine());
            for(count=1;count<=10;count++)
            {
                sum = num * count;
                Console.WriteLine(num + "x" + count + "=" + sum);

            }
            Console.ReadKey();
           
        }
    }
}
