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
            if (args.Length < 2) args = new string[] { "24, 85.3" };

            float firstNumber = float.Parse(args[0]);
            float secondNumber = float.Parse(args[1]);

            float result = AddNumbers(firstNumber, secondNumber);

            Console.WriteLine(result);
        }

        static int AddNumbers (float a, float b)
        {
            int result = (int)(a + b);
            return result;
        }
    }
}
