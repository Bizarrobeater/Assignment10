using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    // Class for assignment 10ø2
    class Counter
    {
        private int counter;
        public Counter()
        {
            counter = 0;
        }

        public int Get() => counter;

        public void Incr() => counter++;
    }
}
