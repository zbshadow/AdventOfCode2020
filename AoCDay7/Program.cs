using System;
using System.IO;
using System.Collections.Generic;

namespace AoCDay7
{
    class Program
    {
        static List<string> colors = new List<string>();

        static void Main(string[] args)
        {        
            colors.Add("shiny gold");

            int change = checkRules();

            while (change != 0)
            {
                change = checkRules();
            }
            
        }

        static int checkRules()
        {
            string file = @"E:\Programs\AdventOfCode\AoCDay7\input.txt";
            int change = 0;
            string line;

            StreamReader input = new StreamReader(file);
            List<string> newColors = new List<string>();

            while ((line = input.ReadLine()) != null)
            {
                foreach (string color in colors)
                {
                    if (line.Contains(color))
                    {
                        string[] x = line.Split(" bags contain ");
                        if (x[1].Contains(color))
                        {
                            if (!(colors.Contains(x[0])))
                            {
                                newColors.Add(x[0]);
                                break;
                            }
                        }
                    }
                }

                foreach (string y in newColors)
                {
                    colors.Add(y);
                    change++;
                }
                newColors.Clear();
            }

            Console.WriteLine("\nNumber of colors: " + (colors.Count - 1));
            Console.WriteLine("Number of changes: " + change);
            return change;
        }
    }
}
