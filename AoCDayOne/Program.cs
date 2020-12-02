using System;
using System.Collections.Generic;
using System.IO;

namespace SortAndFindSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //array
            List<int> inputs = new List<int>();
            string line;
            string inputsFile = "E:\\Programs\\SortAndFindSum\\SortAndFindSumOfThreeNumbers\\input.txt";

            System.IO.StreamReader file = new System.IO.StreamReader(inputsFile);
            while((line = file.ReadLine()) != null)
            {
                inputs.Add(Int32.Parse(line));
            }

            file.Close();

            //sort
            inputs.Sort();
            bool goal = false;
            int a = 0;
            int b = 1;
            int c = 2;

            while (goal == false)
            {
                goal = equalsGoal(inputs[a], inputs[b], inputs[c]);
                if (goal)
                {
                    Console.WriteLine($"{a} + {b} + {c} are equal to 2020", inputs[a], inputs[b], inputs[c]);
                    int winner = inputs[a] * inputs[b] * inputs[c];
                    Console.WriteLine("Your winning value is " + winner);
                }

                if(c < inputs.Count - 1)
                {
                    c++;
                    if (b < inputs.Count - 1)
                    {
                        b++;
                        a++;
                    }
                    else
                    {
                        b = a + 1;
                        a++;
                    }
                }
                else
                {
                    c = b + 1;
                    b++;
                }
                if (b < inputs.Count - 1)
                {
                    b++;
                }
                else
                {
                    b = a + 1;
                    a++;
                }

            }

            //find the sum of two elements that equals 2020
            bool equalsGoal(int x, int y, int z)
            {
                int n = 2020;
                int sum = x + y + z;

                if (sum == n)
                    return true;
                else
                    return false;
            }


            //if sum is 2020 then multiply
        }
    }
}
