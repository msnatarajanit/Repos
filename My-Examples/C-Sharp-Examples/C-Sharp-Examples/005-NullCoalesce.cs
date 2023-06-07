namespace C_Sharp_Examples
{
    internal class _5_NullCoalesce
    {
        void Main() 
        {
            int? age = null;

            //age = 10;

            age = age ?? 0;

            if (age.HasValue)
            {
                Console.WriteLine("Age has value");
            }
            else
            {
                Console.WriteLine("Age has No value");
            }

            Console.WriteLine(age);
        }
    }
}
