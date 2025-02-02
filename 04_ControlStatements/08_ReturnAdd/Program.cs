namespace _08_ReturnAdd;

class Program
{
    static void Main(string[] args)
    {
        int a = 35;
        int b = 25;
        int sum = 0;

        sum = add(a, b);

        Console.WriteLine("Sum is " + sum);
    }

    public static int add(int x, int y)
    {
        return (x + y);
    }
}
