using Microsoft.Extensions.ObjectPool;

class Test
{
    void TestObjPool()
    {
        var defalutPolicy = new DemoPooledObjectPolicy();
        //最大可保留对象数量 = Environment.ProcessorCount * 2
        var defaultPool = new DefaultObjectPool<Demo>(defalutPolicy);

        for (int i = 0; i < 10; i++)
        {
            var item1 = defaultPool.Get();
            Console.WriteLine($"#{i + 1}-{item1.Id}-{item1.Name}-{item1.CreateTimte}");
        }
    }

    static void Main(string[] args)
    {
        // TestConcurrentBag.ConcurrentBagWithPallel();

        Console.WriteLine("Demo for put characters and words in floating point number");
        Console.WriteLine(String.Format("{0:0.00}", 256.3654));
        Console.WriteLine(String.Format("{0:0},{2}", 256.3654, 256, 259.0));
        Console.WriteLine(String.Format("{0:Number is 0.00}", 256.3));
        Console.WriteLine(String.Format("{0:0xxx.yyy0}", 256.3));

        Console.WriteLine();

        Console.Read();
    }
}