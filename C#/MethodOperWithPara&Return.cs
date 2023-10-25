using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOperWithPara_Return
{
    internal class Program
    {
        static int calculate(int n1,int n2,char op)
        {
            int res = 0;
            if (op == '+')
                res = n1 + n2;
            else if (op == '-')
                res = n1 - n2;
            else if (op == '*')
                res = n1 * n2;
            else if (op == '/')
                res = n1 / n2;
            else
                Console.WriteLine("Invalid Operator");
            return res;

        }
        static void Main(string[] args)
        {
            int num1, num2,result;
            char op;
            Console.WriteLine("Enter Num 1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num 2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Op(+,-,*,/):");
            op = Convert.ToChar(Console.ReadLine());
            result=calculate(num1, num2, op);
            Console.WriteLine("Result is :" + result);
            Console.ReadKey();
        }
    }
}
