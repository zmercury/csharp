//Lambda type: Statement Lambda
namespace _05_lambda;

delegate void MyDel(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        MyDel d = (a, b) =>
        {
            Console.WriteLine("The results = " + (a * b));
            Console.WriteLine("End of the program");
        };

        d(2, 3);
    }
}
