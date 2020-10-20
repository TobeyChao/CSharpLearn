using System;

namespace C_Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            TestA testA = new TestA();
            Console.WriteLine(testA.GetDes());
            AppDomain app = new AppDomain();
        }
    }
}
