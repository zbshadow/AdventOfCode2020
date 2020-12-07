using System;
using System.IO;
using System.Collections.Generic;

namespace AoCDay5
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "E:\\Programs\\AdventOfCode\\AoCDay5\\input.txt";

            StreamReader input = new StreamReader(file);
            List<int> seats = new List<int>();
            string line;
            int maxID = 0;

            while((line = input.ReadLine()) != null)
            {
                int row = findValue(line.Substring(0, 8));
                int col = findValue(line.Substring(7));

                int seatID = row * 8 + col;
                if (!(seats.Contains(seatID)))
                {
                    seats.Add(seatID);
                }
                else
                {
                    Console.WriteLine("You have a duplicate issue!");
                }
            }

            foreach (int seat in seats)
            {
                if (!(seats.Contains(seat + 1)))
                {
                    if (seats.Contains(seat + 2))
                    {
                        Console.WriteLine("The missing seat # is: " + (seat + 1));
                    }
                }
            }
        }

        static int findValue(string input)
        {
            int lBound = 0;
            int uBound = 128;

            if (input.Length == 3)
            {
                lBound = 0;
                uBound = 8;
            }


            for(int i = 0; i < input.Length; i++)
            {
                int x = (uBound - lBound) / 2;
                if(input[i] == 'F' || input[i] == 'L')
                {
                    uBound = uBound - x;
                }
                else if(input[i] == 'B' || input[i] == 'R')
                {
                    lBound = lBound + x;
                }
            }

            if (lBound == uBound - 1)
            {
                return lBound;
            }
            else
            {
                Console.WriteLine("There was an issue.");
            }


            return lBound;
        }
    }
}
