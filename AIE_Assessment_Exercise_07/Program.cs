﻿
using System;

namespace AIE_Assessment_Exercise_07
{
    public class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            // Create instances of
            // - A Person and Doctor classes.

            Person p1 = new Person("Bob");
            Doctor p2 = new Doctor("Fred", "10000000");
            Person p3 = new Doctor("Ted", "10000000");

            // Invoke the "SayGreeting" method on the above instances
            p1.SayGreeting(); // hello I'm Bob
            p2.SayGreeting(); // hello I'm Dr. Fred
            p3.SayGreeting(); // hello I'm Dr. Ted
        }
    }
}
