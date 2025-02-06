﻿namespace a_VirtualMethod;

class SuperClass
{
    public virtual int add(int a, int b)
    {
        return a + b;
    }
}

class SubClass : SuperClass
{
    public override int add(int a, int b)
    {
        return (a + b + 5);
    }
}

class Program
{
    static void Main(string[] args)
    {
        SubClass s1 = new SubClass();
        Console.WriteLine("The sum is " + s1.add(10, 20));
    }
}
