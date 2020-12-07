using System;
using System.IO;
using System.Collections.Generic;

namespace AoCDay4Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "E:\\Programs\\AdventOfCode\\AoCDay4Part2\\input.txt";
            string line;
            string pString = "";
            int valid = 0;

            System.IO.StreamReader input = new System.IO.StreamReader(file);
            while ((line = input.ReadLine()) != null)
            {
                if (line != "")
                {
                    string[] LineE = line.Split(' ');
                    foreach (string el in LineE)
                    {
                        pString = pString + el + " ";
                    }
                }
                else
                {
                    bool validByr = false;
                    bool validIyr = false;
                    bool validEyr = false;
                    bool validHgt = false;
                    bool validHcl = false;
                    bool validEcl = false;
                    bool validPid = false;

                    string[] fields = pString.Split(' ');
                    if (fields.Length - 1 == 8 || fields.Length - 1 == 7)
                    {
                        foreach(string field in fields)
                        {
                            string[] parts = field.Split(':');
                            switch (parts[0])
                            {
                                case "byr":
                                    validByr = validateByr(parts);
                                    break;

                                case "iyr":
                                    validIyr = validateIyr(parts);
                                    break;

                                case "eyr":
                                    validEyr = validateEyr(parts);
                                    break;

                                case "hgt":
                                    validHgt = validateHgt(parts);
                                    break;

                                case "hcl":
                                    validHcl = validateHcl(parts);
                                    break;

                                case "ecl":
                                    validEcl = validateEcl(parts);
                                    break;

                                case "pid":
                                    validPid = validatePid(parts);
                                    break;

                                default:
                                    break;
                            } 
                        }
                    }

                    if (validByr && validIyr && validEyr && validHgt && validHcl && validEcl && validPid)
                    {
                        valid++;
                    }

                    Console.WriteLine(pString);
                    pString = "";
                }
            }

            Console.WriteLine(valid);
        }

        static bool validateByr(string[] byrField)
        {
            bool valid = false;
            if(byrField[1].Length == 4 && Int32.Parse(byrField[1]) >= 1920 && Int32.Parse(byrField[1]) <= 2002)
            {
                valid = true;
            }

            return valid;
        }

        static bool validateIyr(string[] iyrField)
        {
            bool valid = false;
            if (iyrField[1].Length == 4 && Int32.Parse(iyrField[1]) >= 2010 && Int32.Parse(iyrField[1]) <= 2020)
            {
                valid = true;
            }

            return valid;
        }

        static bool validateEyr(string[] eyrField)
        {
            bool valid = false;
            if (eyrField[1].Length == 4 && Int32.Parse(eyrField[1]) >= 2020 && Int32.Parse(eyrField[1]) <= 2030)
            {
                valid = true;
            }

            return valid;
        }

        static bool validateHgt(string[] hgtField)
        {
            bool valid = false;
            int split = 0;
            split = hgtField[1].IndexOf('i');
            if(split == -1)
            {
                split = hgtField[1].IndexOf('c');
                if(split == -1)
                {
                    return valid;
                }
                else
                {
                    if ((Int32.Parse(hgtField[1].Substring(0,split))) >= 150 && (Int32.Parse(hgtField[1].Substring(0, split))) <= 193)
                    {
                        valid = true;
                    }
                    return valid;
                }
            }
            else
            {
                if ((Int32.Parse(hgtField[1].Substring(0, split))) >= 59 && (Int32.Parse(hgtField[1].Substring(0, split))) <= 76)
                {
                    valid = true;
                }
                return valid;
            }
        }

        static bool validateHcl(string[] hclField)
        {
            bool valid = false;
            string hairColor = hclField[1];

            if (hairColor.Length == 7)
            {
                if(hairColor[0] == '#')
                {
                    for(int i = 1; i < hairColor.Length; i++)
                    {
                        if (Char.IsLetterOrDigit(hairColor[i]))
                        {
                            valid = true;
                        }
                        else
                        {
                            valid = false;
                            break;
                        }   
                    }
                }
            }

            return valid;
        }

        static bool validateEcl(string[] eclField)
        {
            bool valid = false;
            
            switch (eclField[1])
            {
                case "amb":
                    valid = true;
                    break;

                case "blu":
                    valid = true;
                    break;

                case "brn":
                    valid = true;
                    break;

                case "gry":
                    valid = true;
                    break;

                case "grn":
                    valid = true;
                    break;

                case "hzl":
                    valid = true;
                    break;

                case "oth":
                    valid = true;
                    break;

                default:
                    valid = false;
                    break;
            }

            return valid;
        }

        static bool validatePid(string[] pidField)
        {
            bool valid = false;
            if (pidField[1].Length == 9)
            {
                string id = pidField[1];

                for (int i = 0; i < id.Length; i++)
                {
                    if (Char.IsDigit(id[i]))
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                        break;
                    }
                }
            }

            return valid;
        }
    }
}
