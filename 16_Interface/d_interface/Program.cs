// interface inherits interface
namespace d_interface;
using System;

interface IOne
{
    public void MethodOne();
}

interface ITwo
{
    public void MethodTwo();
}

interface IThree : IOne, ITwo
{
    public void MethodThree();
}

class Program : IThree
{
    void IOne.MethodOne()
    {
        Console.WriteLine("Body from Interface One");
    }

    void ITwo.MethodTwo()
    {
        Console.WriteLine("Body from Interface Two");
    }

    void IThree.MethodThree()
    {
        Console.WriteLine("Body from Interface Three");
    }

    static void Main(string[] args)
    {
        IThree i = new Program();
        i.MethodOne();
        i.MethodTwo();
        i.MethodThree();
    }
}
