using System.Diagnostics;
using System.Text;

namespace C_Sharp_Examples
{
    internal class _3_StringBuilderConcat
    {
        void Main()
        {
            var testString = "A";

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 10; i++)
            {
                testString += "A";
            }
            stopWatch.Stop();
            var stringConcatTimeElapsed = stopWatch.Elapsed;
            Console.WriteLine($"Time elapsed using string concatenation {stringConcatTimeElapsed}");

            var testSB = new StringBuilder("A");

            stopWatch.Restart();
            for (int i = 0; i < 10; i++)
            {
                testSB.Append("A");
            }
            stopWatch.Stop();
            var sbConcatTimeElapsed = stopWatch.Elapsed;
            Console.WriteLine($"Time elapsed using string builder append is {sbConcatTimeElapsed}");

            Console.WriteLine($"String Builder is {stringConcatTimeElapsed - sbConcatTimeElapsed} faster");
        }
    }
}
