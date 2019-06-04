using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapLyndaC_
{
    class Teacher:Member
    {
        protected decimal salary;
        protected string subject;

        public decimal Salary { get => salary; set => salary = value; }
        public string Subject { get =>subject; set => subject = value; }

        public Teacher()
        {

        }

        public Teacher(string name, string birthday, string address, int phone, decimal salary, string subject)
        {
            Name = name;
            Birthday = birthday;
            Address = address;
            Phone = phone;
            Salary = salary;
            Subject = subject;
        }
    }
}
