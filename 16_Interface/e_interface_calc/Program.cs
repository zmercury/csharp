namespace e_interface_calc;

interface Inumbers
{
    int a;
    int b;
}

interface Iarti
{
    int add(int a, int b);
}

class Calc : Inumbers
{

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
