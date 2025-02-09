namespace b_VirtualMethod;

class Shape
{
    protected int width, breath;

    public Shape(int a = 0, int b = 0)
    {
        width = a;
        breath = b;
    }

    public virtual int area()
    {
        return 0;
    }
}

class Rectriangle : Shape
{
    public Rectriangle(int a = 0, int b = 0) : base(a, b)
    {

    }

    public override int area()
    {
        Console.Write("The Rectriangle ");
        return (width * breath);
    }
}

class Triangle : Shape
{
    public Triangle(int a = 0, int b = 0) : base(a, b)
    {

    }

    public override int area()
    {
        Console.Write("The Triangle ");
        return ((width * breath) / 2);
    }
}

class Caller
{
    public void CallArea(Shape sh)
    {
        int ar;
        ar = sh.area();
        Console.WriteLine("Area = {0}", ar);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Caller cl = new Caller();
        int choice = 0;

        Console.WriteLine("Enter 1 for Area of Triangle");
        Console.WriteLine("Enter 2 for Area of Rectriangle");

        switch (choice)
        {
            case 1:
                {
                    Console.WriteLine("Enter width: ");
                    int wd = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter breath: ");
                    int bt = Convert.ToInt32(Console.ReadLine());
                    Rectriangle r = new Rectriangle(wd, bt);
                    cl.CallArea(t);
                }
        }
    }
}
