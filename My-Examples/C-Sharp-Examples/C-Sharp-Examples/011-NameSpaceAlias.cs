using A = TeamA;
using B = TeamB;

namespace C_Sharp_Examples
{
    internal class _011_NameSpaceAlias
    {
        void Main()
        {
            new A::ProjectA().Print();
            new A.ProjectB().Print();
            new B::ProjectA().Print();
            new B.ProjectB().Print();
        }
    }
}

namespace TeamA
{
    class ProjectA
    {
        internal void Print()
        {
            Console.WriteLine($"{this}");
        }
    }

    class ProjectB
    {
        internal void Print()
        {
            Console.WriteLine($"{this}");
        }
    }
}

namespace TeamB
{
    class ProjectA
    {
        internal void Print()
        {
            Console.WriteLine($"{this}");
        }
    }

    class ProjectB
    {
        internal void Print()
        {
            Console.WriteLine($"{this}");
        }
    }
}
