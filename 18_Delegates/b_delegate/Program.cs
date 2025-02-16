namespace b_delegate;

public delegate void MyDel(int num);

class MyNum
{
    public static void square(int num)
    {
        Console.WriteLine("Square = " + (num * num));
    }

    public static void cube(int num)
    {
        Console.WriteLine("Cube " + (num * num * num));
    }
}

class Program : MyNum
{
    static void Main(string[] args)
    {
        MyDel my = square;
        my(10);
        MyDel my1 = cube;
        my1.Invoke(10);
    }
}
