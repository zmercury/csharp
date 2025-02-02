namespace SumTwoUserInput;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter any two numbers: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        int sum = a + b;

        Console.WriteLine("The sum of {0} and {1} is {2}", a, b, sum);
    }
}
