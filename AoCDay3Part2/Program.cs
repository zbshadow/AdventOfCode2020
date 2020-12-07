using System;
using System.IO;
using System.Collections.Generic;

namespace AoCDay3Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "E:\\Programs\\AdventOfCode\\AocDay3Part2\\input.txt";
            string line;
            List<string> lines = new List<string>();

            System.IO.StreamReader file = new System.IO.StreamReader(input);
            while ((line = file.ReadLine()) != null)
            {
                lines.Add(line);
            }

            int results1 = OneROneD(lines);
            int results2 = ThreeROneD(lines);

            long treeResult = results1 * results2;

            Console.WriteLine("Santa would have hit " + treeResult + " trees");

            int results3 = FiveROneD(lines);

            treeResult = treeResult * results3;

            Console.WriteLine("Santa would have hit " + treeResult + " trees");

            int results4 = SevenROneD(lines);

            treeResult = treeResult * results4;

            Console.WriteLine("Santa would have hit " + treeResult + " trees");

            int results5 = OneRTwoD(lines);

            treeResult = treeResult * results5;

            Console.WriteLine("Santa would have hit " + treeResult + " trees");

        }

        static int OneROneD(List<string> lines)
        {
            int maxL = lines[0].Length - 1;
            int maxD = lines.Count;
            int treeCount = 0;
            int x = 0;
            int y = 0;


            for (int i = 0; i < maxD - 1; i++)
            {
                x = x + 1;
                y = y + 1;

                if (x > maxL)
                {
                    x = x - (maxL + 1);
                }

                if (lines[y][x] == '#')
                {
                    treeCount++;
                }
            }

            Console.WriteLine("Santa would have hit " + treeCount + "trees");

            return treeCount;
        }

        static int ThreeROneD(List<string> lines)
        {
            int maxL = lines[0].Length - 1;
            int maxD = lines.Count;
            int treeCount = 0;
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

                if (lines[y][x] == '#')
                {
                    treeCount++;
                }
            }

            Console.WriteLine("Santa would have hit " + treeCount + "trees");

            return treeCount;
        }

        static int FiveROneD(List<string> lines)
        {
            int maxL = lines[0].Length - 1;
            int maxD = lines.Count;
            int treeCount = 0;
            int x = 0;
            int y = 0;


            for (int i = 0; i < maxD - 1; i++)
            {
                x = x + 5;
                y = y + 1;

                if (x > maxL)
                {
                    x = x - (maxL + 1);
                }

                if (lines[y][x] == '#')
                {
                    treeCount++;
                }
            }

            Console.WriteLine("Santa would have hit " + treeCount + "trees");

            return treeCount;
        }

        static int SevenROneD(List<string> lines)
        {
            int maxL = lines[0].Length - 1;
            int maxD = lines.Count;
            int treeCount = 0;
            int x = 0;
            int y = 0;


            for (int i = 0; i < maxD - 1; i++)
            {
                x = x + 7;
                y = y + 1;

                if (x > maxL)
                {
                    x = x - (maxL + 1);
                }

                if (lines[y][x] == '#')
                {
                    treeCount++;
                }
            }

            Console.WriteLine("Santa would have hit " + treeCount + "trees");

            return treeCount;
        }

        static int OneRTwoD(List<string> lines)
        {
            int maxL = lines[0].Length - 1;
            int maxD = lines.Count;
            int treeCount = 0;
            int x = 0;
            int y = 0;


            for (int i = 0; i < maxD - 1; i++)
            {
                x = x + 1;
                y = y + 2;

                if (y > maxD)
                    break;

                if (x > maxL)
                {
                    x = x - (maxL + 1);
                }

                if (lines[y][x] == '#')
                {
                    treeCount++;
                }
            }

            Console.WriteLine("Santa would have hit " + treeCount + "trees");

            return treeCount;
        }
    }
}
