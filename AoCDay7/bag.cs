using System;
using System.Collections.Generic;
using System.Text;

namespace AoCDay7
{
    class bag
    {
        private string color;
        private int count;

        public bag()
        {

        }

        public bag(int count, string color)
        {
            this.count = count;
            this.color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

    }
}
