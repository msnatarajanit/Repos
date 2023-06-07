namespace C_Sharp_Examples
{
    internal class _8_CallByRef
    {
        void Main()
        {
            int a = 10;

            Console.WriteLine($"Value of a {a}");

            CallByRef(ref a);

            Console.WriteLine($"Value of a after CallByRef {a}");
        }

        static void CallByRef(ref int a)
        {
            a = 20;
        }
    }
}
