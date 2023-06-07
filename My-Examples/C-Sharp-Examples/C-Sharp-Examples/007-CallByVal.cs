using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Examples
{
    internal class _7_CallByVal
    {
        void Main() 
        {
            int a = 10;

            Console.WriteLine($"Value of a {a}");

            int ret = CallByValue(a);

            Console.WriteLine($"Value of a after CallByValue {a}");

            Console.WriteLine($"Value returned {ret}");
        }

        static int CallByValue(int a)
        {
            a = 20;
            return a;
        }

    }
}
