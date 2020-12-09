using System;
using System.Collections.Generic;
using System.Text;

namespace AoCDay7Part2
{
    class rules
    {
        private string name;
        private List<string> contents = new List<string>();

        public rules(string line)
        {
            string[] toSplit = new string[] { " bags contain ", " bags, ", " bag, ", " bag.", " bags." };
            string[] parts = line.Split(toSplit, StringSplitOptions.None);
            this.name = parts[0];
            for(int i = 1; i < parts.Length; i++)
            {
                if(parts[i] != "")
                {
                    contents.Add(parts[i]);
                } 
            }
        }

        public string Name
        {
            get { return name; }
        }

        public List<string> Contents
        {
            get { return contents; }
        }

    }
}
