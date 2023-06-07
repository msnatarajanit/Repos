using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Examples
{
    internal class _6_Arrays
    {
        void Main()
        {
            int[] ints = new int[1];

            ints[0] = 1;
            ints[1] = 2;

            int[] ints1 = new int[] { }; //Dynamic Array

            ints1[0] = 1;
            ints1[1] = 2;

            //Both would throw index out of bounds / range exception            
        }
    }
}
