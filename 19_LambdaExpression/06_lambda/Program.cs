//Trying without using delegate
//Lambda type: Statement Lambda
namespace _06_lambda;

class Program
{
    static void Main(string[] args)
    {
        var calcSum = (int a, int b) =>
        {
            int sum = (a + b);
            return sum;
        };

        Console.WriteLine("The sum is " + calcSum(5, 3));
    }
}
