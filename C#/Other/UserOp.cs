using System;


namespace UsersOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,result;
            Console.Write("Enter Num 1 :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter NUM 2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = num1 + num2;
            Console.WriteLine(num1 +"+"+ num2+"="+ result);

            result = num1 - num2;
            Console.WriteLine(num1+"-"+num2+"="+ result);

            result = num1 * num2;
            Console.WriteLine(num1+"*"+num2+"="+ result);

            result = num1 / num2;
            Console.WriteLine(num1 + "/" + num2 + "=" + result);

            result = num1 % num2;
            Console.WriteLine(num1 + "mod" + num2 + "=" + result);

            Console.ReadKey();

        }
    }
}
