using System;
using Microsoft.Extensions.ObjectPool;

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