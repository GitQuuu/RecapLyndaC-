using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapLyndaC_
{
    class Data
    {
        private string name;
        private int age;
        private string birthMonth;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string BirthMonth { get => birthMonth; set => birthMonth = value; }

        public void Display()
        {
            Console.WriteLine($"\nAccording to your inputs, Name is:{Data.Name} Age is:{Data.Age} Birth of month is:{Data.BirthMonth}");
        }

    }
}
