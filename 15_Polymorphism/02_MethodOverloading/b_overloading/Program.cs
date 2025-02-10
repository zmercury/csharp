namespace b_overloading;

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

    public string add(string a, string b)
    {
        return (a + b);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyCalc mc = new MyCalc();

        Console.WriteLine("Sum of two numbers: " + mc.add(1, 2));
        Console.WriteLine("Sum of three numbers: " + mc.add(3, 1, 2));
        Console.WriteLine("Sum of two names is : " + mc.add("Hello ", "World"));
    }
}

