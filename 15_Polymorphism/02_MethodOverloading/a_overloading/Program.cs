namespace _02_MethodOverloading;

// Method overloading using different number of parameters but same datatype
class MyCalc
{
    public int add(int a, int b)
    {
        return (a + b);
    }

    public int add(int a, int b, int c)
    {
        return (a + b + c);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyCalc mc = new MyCalc();

        Console.WriteLine("Sum of two numbers: " + mc.add(1, 2));
        Console.WriteLine("Sum of three numbers: " + mc.add(3, 1, 2));
    }
}
