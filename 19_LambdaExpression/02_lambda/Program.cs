namespace _02_lambda;

delegate int MyDel(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        MyDel d = (a, b) => (a + b);
        int value = d(10, 20);
        Console.WriteLine("The sum is " + value);
    }
}
