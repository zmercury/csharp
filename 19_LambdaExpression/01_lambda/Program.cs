//Lambda type: Expression Lambda
namespace _01_lambda;

delegate int MyDel(int a);

class Program
{
    static void Main(string[] args)
    {
        MyDel d = a => a * a;
        int value = d(5);
        Console.WriteLine("The result is " + value);
    }
}
