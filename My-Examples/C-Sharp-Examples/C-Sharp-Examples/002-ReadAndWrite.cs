using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Examples
{
    internal class _2_ReadAndWrite
    {
        void Main()
        {
            Console.Write("Enter your first name : ");
            var firstName = Console.ReadLine();

            Console.Write("Enter your middle name : ");
            var middleName = Console.ReadLine();

            Console.Write("Enter your last name : ");
            var lastName = Console.ReadLine();

            Console.WriteLine("Your first name is " + firstName);

            Console.WriteLine("Your middle name is {0}", middleName);

            Console.WriteLine($"Your last name is {lastName}");
        }
    }
}
