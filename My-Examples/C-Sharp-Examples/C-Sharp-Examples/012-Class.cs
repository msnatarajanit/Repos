namespace C_Sharp_Examples
{
    internal class _012_Class
    {
        void Main()
        {
            var customer = new Customer();
            customer.PrintName();

            customer = new Customer("Robert", "Hanks");
            customer.PrintName();
        }
    }

    class Customer
    {
        private readonly string _firstName;
        private readonly string _lastName;

        public Customer() : this("No First Name Provided", "No Last Name Provided")
        {

        }

        public Customer(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        internal void PrintName()
        {
            Console.WriteLine($"Full Name is {_firstName} {_lastName}");
        }

        ~Customer() //Destructor. Called automatically by GC. But cannot verify when it is called.
        {
            Console.WriteLine("Destructor is called");
        }

    }
}
