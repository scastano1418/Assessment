/*
 * Appendix 1 - Exercise 2: Fibonacci
 */

using System;

namespace AIE_Assessment_Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = 0;

            if (args.Length < 1)
            {
                args = new string[] { "10" };
            }

            numberOfElements = Int32.Parse(args[0]);

            fibonocci(numberOfElements);
  
            // TODO:
            // Write a function that will, given an integer n, calculate the first n numbers in the 
            // Fibonacci sequence given starting elements of (0, 1). 
            // Output your result to the console
        }

        static void fibonocci(int n)
        {
            int a = 0;
            int b = 1;

            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < n; i++)
            {
                int c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
    }
}
