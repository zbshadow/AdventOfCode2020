using System;
using System.IO;
using System.Collections.Generic;


namespace AoCDay2Part1
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
            while((line = file.ReadLine()) != null)
            {
                lines.Add(line);
            }

            Console.WriteLine(lines.Count);

            foreach (var l in lines)
            {
                string x = l.Trim(' ');
                string[] parts = SplitLine(x);

                //foreach(var part in parts)
                //{
                //    Console.WriteLine(part);
                //}

                int min = Int32.Parse(parts[0]);
                int max = Int32.Parse(parts[1]);
                string req = parts[2];
                string pass = parts[4];

                int count = 0;

                foreach(char y in pass)
                {
                    if (y == req[0])
                    {
                        count++;
                    }
                }

                if (count <= max && count >= min)
                    ValidPass.Add(pass);
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
