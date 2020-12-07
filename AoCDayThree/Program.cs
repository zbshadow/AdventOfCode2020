using System;
using System.IO;
using System.Collections.Generic;

namespace AoCDayThree
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "E:\\Programs\\AdventOfCode\\AocDayThree\\input.txt";
            string line;
            List<string> lines = new List<string>();

            System.IO.StreamReader file = new System.IO.StreamReader(input);
            while ((line = file.ReadLine()) != null)
            {
                lines.Add(line);
            }

            int maxL = lines[0].Length - 1;
            int maxD = lines.Count;
            int treesHit = 0;
            int x = 0;
            int y = 0;


            for (int i = 0; i < maxD - 1; i++)
            {
                x = x + 3;
                y = y + 1;

                if (x > maxL)
                {
                    x = x - (maxL + 1);
                }

                if(lines[y][x] == '#')
                {
                    treesHit++;
                }
            }

            Console.WriteLine("Santa would have hit " + treesHit + "trees");
            
        }
    }
}
