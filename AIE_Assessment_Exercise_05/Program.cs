/*
 * Appendix 2 - Exercise 2: Sorting an Array (Descending)
 */


using System;

namespace AIE_Assessment_Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input comma separated list of numbers");
            string lineOfText = Console.ReadLine();
            string[] values = lineOfText.Split(',');

            int[] numbers = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                numbers[i] = Int32.Parse(values[i]);
            }

            SortDescending(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
        }

        static void SortDescending(int[] numbers)
        {
            for (int j = 0; j < numbers.Length + 1; j++)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] < numbers[i + 1])
                    {
                        int temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }

        }

    }
}
