using System;


namespace IfelseGradePerBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3,total;
            float per;
            string grade;
            Console.Write("Enter Sub1 :");
            sub1=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Sub1 :");
            sub2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Sub1 :");
            sub3 = Convert.ToInt32(Console.ReadLine());

            total = sub1 + sub2 + sub3;
            per = total / 300.0f * 100.0f;

            if(per>75)
            {
                grade = "First Grade";
            }
            else if(per>60 && per<=75)
            {
                grade = "Second Grade";
            }
            else if (per > 45 && per <= 60)
            {
                grade = "Third Grade";
            }
            else
            {
                grade = "Fail";
            }
            Console.Write("Total Marks: {0},Percent: {1}, Grade: {2}", total, per, grade);
            Console.ReadKey();







        }
    }
}
