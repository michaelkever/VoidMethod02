using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voidMethod02
{
    class TwoDivision
    {
        public int numDivision(int num01, int num02 = 2)
        {
            return num01 / num02;
        }

        public int numDivision01(int num01, int num02)
        {
            num01 = 1;
            num02 = 2;
            int total = num01 + num02;
            return total;

        }
    }
   
}
