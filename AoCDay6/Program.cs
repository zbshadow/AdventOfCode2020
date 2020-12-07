using System;
using System.IO;
using System.Collections.Generic;

namespace AoCDay6
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"E:\Programs\AdventOfCode\AoCDay6\input.txt";
            string line;
            int sum = 0;

            StreamReader input = new StreamReader(file);
            List<char> x = new List<char>();

            while ((line = input.ReadLine()) != null)
            {
                if (line.Length > 0)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!(x.Contains(line[i])))
                            x.Add(line[i]);
                    }
                }
                else
                {
                    sum = sum + x.Count;
                    x.Clear();
                }
            }

            Console.WriteLine(sum);
        }
    }
}