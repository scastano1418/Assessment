using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_07
{
    public class Person
    {
        public string name;
        public string email;
        public string phone;

        public Person()
        {
            name = "";
            email = "";
            phone = "";
        }

        public Person(string name)
        {
            this.name = name;
            this.email = "";
            this.phone = "";
        }

        public virtual void SayGreeting()
        {
            Console.WriteLine("Hello, I'm " + name);
        }
        
    }
}
