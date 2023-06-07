namespace C_Sharp_Examples
{
    internal class _9_CallUsingOut
    {
        void Main()
        {
            int a = 10;
            int b = 20;

            int sum = 0;
            int product = 0;

            Console.WriteLine($"Demo returning more than one value from method using out parameters...");

            Console.WriteLine($"a : {a}");
            Console.WriteLine($"b : {b}");

            CallUsingOutParameters(a, b, out sum, out product);

            Console.WriteLine($"Sum : {sum} Product : {product}");
        }

        static void CallUsingOutParameters(int a, int b, out int sum, out int product)
        {
            sum = a + b; ;
            product = a * b;
        }
    }
}
