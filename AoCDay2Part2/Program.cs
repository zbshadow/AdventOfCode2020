using System;
using System.IO;
using System.Collections.Generic;


namespace AoCDay2Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "E:\\Programs\\AdventOfCode\\AoCDay2Part2\\input.txt";
            string line;
            List<string> lines = new List<string>();
            List<string> ValidPass = new List<string>();

            System.IO.StreamReader file = new System.IO.StreamReader(input);
            while ((line = file.ReadLine()) != null)
            {
                lines.Add(line);
            }

            Console.WriteLine(lines.Count);

            foreach (var l in lines)
            {
                string x = l.Trim(' ');
                string[] parts = SplitLine(x);

                int first = Int32.Parse(parts[0]) - 1;
                int second = Int32.Parse(parts[1]) - 1;
                string req = parts[2];
                string pass = parts[4];

                if (pass[first] == req[0])
                {
                    if (pass[second] != req[0])
                        ValidPass.Add(pass);
                }
                else if (pass[second] == req[0])
                {
                    ValidPass.Add(pass);
                }
            }

            Console.WriteLine(ValidPass.Count);

        }

        static string[] SplitLine(string s)
        {
            char[] breaks = { ':', '-', ' ' };

            string[] parts = s.Split(breaks);

            return parts;
        }
    }
}
