using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapLyndaC_
{
    class Program
    {
    
        static void Main(string[] args)
        {

            ///Challenge Survey OOP
            ///Use a class to store survey data use OOP 

            Data Data = new Data();

            Data.Name = Util.Ask("What is your name?");

            Console.WriteLine("How old are you");
            bool forceAgetoInt = true;
            while (forceAgetoInt)
            {
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    Data.Age = age;
                    forceAgetoInt = false;
                }
                else
                {
                    Console.WriteLine("value must be a number, try again");
                }
                
            }
            
            Data.BirthMonth = Util.Ask("What month were you born in?");
    
            Console.WriteLine($"\nAccording to your inputs, Name is:{Data.Name} Age is:{Data.Age} Birth of month is:{Data.BirthMonth}");


            Console.ReadLine();

        }
    }
}
