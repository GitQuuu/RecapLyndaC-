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
        
            Console.WriteLine("What is your name?");
            Data.Name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            Data.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("What month were you born in?");
            Data.BirthMonth = Console.ReadLine();
            
            Console.WriteLine($"\nAccording to your indication, Name is:{Data.Name} Age is:{Data.Age} Birth of month is:{Data.BirthMonth}");


            Console.ReadLine();

        }
    }
}
