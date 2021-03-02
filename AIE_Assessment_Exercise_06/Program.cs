using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AIE_Assessment_Exercise_06
{
    class Program
    {
        static List<string> words = new List<string>();

        static void Main(string[] args)
        {
            LoadFile("./wordlist/words.txt");

            Print();
        }

        static void LoadFile(string filename)
        {
            using (StreamReader sr = File.OpenText(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    words.Add(line);
                }
            }
        }

        static void Print()
        {
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
        }
    }



}
