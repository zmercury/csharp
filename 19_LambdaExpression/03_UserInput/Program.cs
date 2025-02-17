namespace _03_UserInput;

delegate int MyDel(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        MyDel d = (a, b) => (a + b);

        (int one, int two) = GetInput();
        (int one, int two, int three) = GetThreeInput();

        int value = d(one, two);
        int valueThree = d(one, two, three);
        Console.WriteLine("The sum is " + value);
        Console.WriteLine("The sum of three num:  " + valueThree);
    }

    static (int, int) GetInput()
    {
        Console.WriteLine("Enter the value of A: ");
        int numOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of B: ");
        int numTwo = Convert.ToInt32(Console.ReadLine());

        return (numOne, numTwo);
    }

    static (int, int, int) GetThreeInput()
    {
        Console.WriteLine("Enter the value of A: ");
        int numOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of B: ");
        int numTwo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of C: ");
        int numThree = Convert.ToInt32(Console.ReadLine());

        return (numOne, numTwo, numThree);
    }
}

