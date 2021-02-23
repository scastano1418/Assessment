/*
 * Appendix 1 - Exercise 1: Adding Two Numbers
 */

using System;

namespace AIE_Assessment_Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstNumber = 0f;
            float secondNumber = 0f;
           

            if (args.Length < 2) args = new string[] { "1.1", "3.89" };

            firstNumber = float.Parse(args[0]);
            secondNumber = float.Parse(args[1]);

            float AddNumbers( float a, float b)
            {
                float result =  a + b;
                return (result);
            }

            Console.WriteLine(AddNumbers(1.1f, 3.89f)); 
        }
    }
}
