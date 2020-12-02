using System;
using Microsoft.Extensions.ObjectPool;

namespace C_Learn
{
    public class Demo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateTimte { get; set; }
    }

    public class DemoPooledObjectPolicy : IPooledObjectPolicy<Demo>
    {
        public Demo Create()
        {
            return new Demo { Id = 1, Name = "catcher", CreateTimte = DateTime.Now };
        }

        public bool Return(Demo obj)
        {
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
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
    }
}