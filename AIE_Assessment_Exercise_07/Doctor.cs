using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_07
{
     public class Doctor : Person
     {
        public string salary;
        
        public Doctor() : base()
        {
            this.salary = "";
        }

        public Doctor(string name, string salary): base(name)
        {
            this.salary = salary;
        }

        public override void SayGreeting()
        {
            Console.WriteLine("Hello, I'm Dr. " + name);
        }
     }
}
