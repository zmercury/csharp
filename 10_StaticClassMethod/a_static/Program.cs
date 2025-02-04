namespace a_static;

static class Shape
{
    public static int length = 34;

    public static int areaCircle()
    {
        return (length * length);
    }

    public static int cube(int a)
    {
        return (a * a * a);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The length is " + Shape.length);
        Console.WriteLine("The area of square is " + Shape.areaCircle() + " u. sq.");
        Console.WriteLine("Cube of a number is " + Shape.cube(5));
    }
}
