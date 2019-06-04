using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapLyndaC_
{
    class Member
    {
        protected string name;
        protected string birthday;
        protected string address;
        protected int phone;

        public string Name { get => name; set => name = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Address { get => address; set => address = value; }
        public int Phone { get => phone; set => phone = value; }

        

    }
}
