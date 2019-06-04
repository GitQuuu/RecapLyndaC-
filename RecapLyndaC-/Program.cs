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

            bool forceAgetoInt = true;
            do
            {
               if (int.TryParse(Util.Ask("What is your age?"), out int result))
                {
                    result = Data.Age;
                    forceAgetoInt = false;
                }
                else
                {
                    Console.WriteLine("Value must be a number, please try again");
                }
              
            } while (forceAgetoInt);

            
            /// Does the same for line 22-35 just a different way to approch the result 
            ///Console.WriteLine("what is your age");
            ///bool forceAgetoInt = true;
            ///while (forceAgetoInt)
            ///{
            ///    if (int.TryParse(Console.ReadLine(), out int age))
            ///    {
            ///        Data.Age = age;
            ///        forceAgetoInt = false;
            ///    }
            ///    else
            ///    {
            ///        Console.WriteLine("value must be a number, try again");
            ///    }
            ///
            ///}


            Data.BirthMonth = Util.Ask("What month were you born in?");
    
            Console.WriteLine($"\nAccording to your inputs, Name is:{Data.Name} Age is:{Data.Age} Birth of month is:{Data.BirthMonth}");


            Console.ReadLine();

        }
    }
}
