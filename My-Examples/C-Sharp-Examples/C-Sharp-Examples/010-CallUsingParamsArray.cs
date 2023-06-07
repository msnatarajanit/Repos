using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Examples
{
    internal class _10_CallUsingParamsArray
    {
        void Main()
        {
            Console.WriteLine("Passing arguments for params array on the fly...");

            CallUsingParamsArray(1, 2, 3, 4, 5);

            int[] array = new int[] { 100, 99, 98, 97 };

            Console.WriteLine("Passing int array as argument for params array parameter...");

            CallUsingParamsArray(array);

            Console.WriteLine("Passing a normal argument and another argument for params array for last parameter...");

            CallUsingLastParameterAsParamsArray("First Parameter", array);
        }

        static void CallUsingParamsArray(params int[] parameters)
        {
            foreach (var parameter in parameters)
            {
                Console.WriteLine(parameter);
            }
        }

        static void CallUsingLastParameterAsParamsArray(string a, int[] parameters)
            => CallUsingParamsArray(1000, 1002, 1003, 1004);

    }

}
