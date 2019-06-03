using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapLyndaC_
{
    class Util
    {

        static public string Ask(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

    }
}
