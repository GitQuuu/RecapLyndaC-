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
            
            ///Multiple Choice question Task
            ///Create a simple three-question survey
            ///1. what is your name 2. How old are you 3.What month were you born in
            ///Output the answers back into the console

            string name;
            int age;
            string birthMonth;
        
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("What month were you born in?");
            birthMonth = Console.ReadLine();
            
            Console.WriteLine($"\nAccording to your indication, Name is:{name} Age is:{age} Birth of month is:{birthMonth}");


            Console.ReadLine();

        }
    }
}
