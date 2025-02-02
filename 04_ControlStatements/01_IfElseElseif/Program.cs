namespace _01_IfElseElseif;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 0)
        {
            Console.WriteLine("Zero");
        }
        else if (num < 0)
        {
            Console.WriteLine(num + " is a negative number");
        }
        else
        {
            Console.WriteLine(num + " is a positive number");
        }
    }
}
