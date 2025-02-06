namespace _01_Classword;

abstract class Head
{
    public abstract int getNum(int num);
}

class Square : Head
{
    public override int getNum(int num)
    {
        return (num * num);
    }
}

class Cube : Head
{
    public override int getNum(int num)
    {
        return (num * num * num);
    }
}

class PwrFour : Head
{
    public override int getNum(int num)
    {
        return (num * num * num * num);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Head h;
        h = new Square();
        h = new Cube();
        h = new PwrFour();

        Console.WriteLine("Square = " + );
        Console.WriteLine("Square = ");
        Console.WriteLine("Square = ");
    }
}
