using System;

namespace C_Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            TestA testA = new TestA();
            Console.WriteLine(testA.GetDes());
            Console.WriteLine("Demo for put characters and words in floating point number");
            Console.WriteLine(String.Format("{0:0.00}", 256.3654));   
            Console.WriteLine(String.Format("{0:0},{2}", 256.3654, 256, 259.0));   
            Console.WriteLine(String.Format("{0:Number is 0.00}", 256.3));   
            Console.WriteLine(String.Format("{0:0xxx.yyy0}", 256.3));          
 
            Console.WriteLine(); 
        }
    }
}
