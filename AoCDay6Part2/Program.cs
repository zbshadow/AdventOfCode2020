using System;
using System.IO;
using System.Collections.Generic;

namespace AoCDay6Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"E:\Programs\AdventOfCode\AoCDay6Part2\input.txt";
            string line;
            List<string> group = new List<string>();
            int sum = 0;

            StreamReader input = new StreamReader(file);
            List<char> x = new List<char>();

            while ((line = input.ReadLine()) != null)
            {
                if (line.Length > 0)
                {
                    group.Add(line);
                }
                else
                {
                    string p1 = group[0];
                    for (int i = 0; i < p1.Length; i++)
                    {
                        int count = 1;
                        for (int y = 1; y < group.Count; y++)
                        {
                            if (!(group[y].Contains(p1[i])))
                            {
                                break;
                            }
                            else
                            {
                                count++;
                            }
                        }

                        if (count == group.Count)
                        {
                            sum++;
                        }
                    }

                    group.Clear();
                }
            }

            Console.WriteLine(sum);
        }
    }
}
