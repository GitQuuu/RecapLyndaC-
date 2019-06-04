using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    class Console
    {
        /// <summary>
        /// Creating a class name Console to force an error from our main program class , this will conflict our Console.WriteLine, because our main is trying to find 
        /// a Console.WriteLine inside our Console class which doesnt excist, we could simply rename our class to something else, but we do this to show that its a namespace
        /// issue and can be prevented by renameing our namespace to something like Util
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>


        /// we wanna create a function that ask a question and takes in a Console.ReadLine(); since we do that alot
        /// 
        static public string Ask(string question)
        {
            System.Console.WriteLine(question);
            return System.Console.ReadLine();
        }


    }
}
