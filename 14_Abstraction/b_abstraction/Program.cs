namespace b_abstraction;

abstract class MyClass
{
    public int calc(int a, int b)
    {
        return (a + b);
    }
}

class YourClass : MyClass
{
    public int mil(int a, int b)
    {
        return (a * b);
    }
}

class Program
{
    static void Main(string[] args)
    {
        YourClass n = new YourClass();
        int result = n.calc(10, 20);
        Console.WriteLine("Result = " + result);
        int resultMul = n.mul(10, 20);
        Console.WriteLine("Result = " + resultMul);
    }
}
