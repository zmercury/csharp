namespace _04_Test;

class HelloWorld
{
    public void hello()
    {
        Console.WriteLine("Hello world!");
    }

    public string hi(string name)
    {
        return "Hi " + name;
    }

    public string age(int num)
    {
        return "Age " + num;
    }
}

class Program
{
    int helloMain()
    {
        Console.WriteLine("Hello World!");
    }

    static void Main(string[] args)
    {
        HelloWorld hw = new HelloWorld();
        helloMain();

        hw.hello();
        Console.WriteLine(hw.hi("Nikhil"));

        Console.WriteLine(hw.age(10));
    }
}
