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

            words.RemoveAt(0);

            words.Sort();

            CreateFile("./wordlist/output.txt");
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

        static void CreateFile(string filename)
        {
            var fileInfo = new FileInfo(filename);
            Directory.CreateDirectory(fileInfo.Directory.FullName);

            using (StreamWriter sw = File.CreateText(filename))
            {
                foreach (string s in words)
                {
                    sw.WriteLine(s);
                }  
            }
        }
    }
}
