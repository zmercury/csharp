//Lambda type: Expression Lambda
namespace _04_lambda;

delegate int MyDel(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        MyDel d = (a, b) => a > b ? a : b;
        (int a, int b) = GetInput();

        int value = d(a, b);
        Console.WriteLine("The larger value is " + value);
    }

    static (int, int) GetInput()
    {
        Console.WriteLine("Enter the value of two numbers: ");
        int one = Convert.ToInt32(Console.ReadLine());
        int two = Convert.ToInt32(Console.ReadLine());
        return (one, two);
    }
}
