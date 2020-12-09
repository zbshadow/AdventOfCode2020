using System;
using System.IO;
using System.Collections.Generic;

namespace AoCDay7Part2
{
    class Program
    {
        static List<rules> rulesList = new List<rules>();
        static List<string> bags = new List<string>();
        static List<string> usedBags = new List<string>();
        static List<string> newBags = new List<string>();
        static bool update;
        static int total = 0;

        static void Main(string[] args)
        {
            loadRules();

            bags.Add("shiny gold");
            update = true;

            while (update)
            {
                getContents();

                foreach (string bag in usedBags)
                {
                    bags.Remove(bag);
                }
                if (newBags.Count > 0)
                {
                    foreach (string bag in newBags)
                    {
                        bags.Add(bag);
                    }
                    update = true;
                    newBags.Clear();
                }
            }

            Console.WriteLine("Final bag count: " + total);
        }

        static void loadRules()
        {
            string file = @"E:\Programs\AdventOfCode\AoCDay7Part2\input.txt";
            string line;

            StreamReader input = new StreamReader(file);

            while ((line = input.ReadLine()) != null)
            {
                rulesList.Add(new rules(line));
            }
        }

        static void getContents()
        {
            foreach(string bag in bags)
            {
                usedBags.Add(bag);
                rules rule = rulesList.Find(r => r.Name == bag);
                
                foreach(string contents in rule.Contents)
                {
                    if(contents[1] == ' ')
                    {
                        int quantity = Int32.Parse(contents[0].ToString());
                        for(int q = 0; q < quantity; q++)
                        {
                            newBags.Add(contents.Substring(2));
                        }
                        total += quantity;
                    }
                }
            }
            update = false;
        }
    }
}
