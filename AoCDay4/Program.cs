using System;
using System.IO;
using System.Collections.Generic;

namespace AoCDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "E:\\Programs\\AdventOfCode\\AoCDay4\\input.txt";
            string line;
            string pString = "";
            int valid = 0;

            System.IO.StreamReader input = new System.IO.StreamReader(file);
            while((line = input.ReadLine()) != null)
            {
                if(line != "")
                {
                    string[] LineE = line.Split(' ');
                    foreach(string el in LineE)
                    {
                        pString = pString + el + " ";
                    }
                }
                else
                {
                    Console.WriteLine(pString);
                    string[] fields = pString.Split(' ');
                    Console.WriteLine(fields.Length);
                    if(fields.Length - 1 == 8)
                    {
                        Console.WriteLine("has 8");
                        valid++;
                    }
                    else if(fields.Length - 1 == 7)
                    {
                        Console.WriteLine("has 7");
                        bool containsCID = true;
                        foreach (string field in fields)
                        {
                            string[] parts = field.Split(':');
                            Console.WriteLine(parts[0]);
                            if(parts[0] == "cid")
                            {
                                containsCID = true;
                            }
                            else
                            {
                                containsCID = false;
                            }

                            if (containsCID)
                                break;
                        }
                        if (!containsCID)
                        {
                            valid++;
                        }
                    }

                    pString = "";
                }
            }

            Console.WriteLine(valid);
        }
    }
}
