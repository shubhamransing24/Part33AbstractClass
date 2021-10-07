using System;
using System.Collections.Generic;
using System.Text;

namespace Part33AbstractClass
{
     abstract class Employee
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastnName { get; set; }
        public abstract void Print();
    
    }
}
