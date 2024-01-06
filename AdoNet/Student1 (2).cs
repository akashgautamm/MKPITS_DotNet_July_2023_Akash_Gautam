using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
      public int Rno { get; set; }
      public string Name { get; set;}
      public string City { get; set; }
      public string Gender { get; set; }
      public string Hobby { get; set; }
      public string Date {  get; set; }
      public Student(int Rno,string Name,string City,string Gender,string Hobby,string Date)
      {
            this.Rno = Rno;
            this.Name = Name;
            this.City = City;
            this.Gender = Gender;
            this.Hobby = Hobby;
            this.Date = Date;
      }


    }
}
