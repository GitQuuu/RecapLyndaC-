using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapLyndaC_
{
    class Student:Member
    {
        static public int Count = 0;

        protected int grade;
     
        public int Grade { get => grade; set => grade = value; }        

        public Student()
        {

        }

        public Student( string name, int grade, string birthday, string address, int phone)
        {
            Grade = grade;
            Name = name;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }

    }
}
