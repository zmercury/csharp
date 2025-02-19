namespace _03_UserInput;

delegate int MyDel(int a, int b, int c, int d);

class Program
{
    static void Main(string[] args)
    {
        MyDel e = (a, b, c, d) => (a + b + c + d);

        (int one, int two, int three, int four) = GetInput();

        int valueFour = e(one, two, three, four);
        Console.WriteLine("The sum of four num:  " + valueFour);
    }

    static (int, int, int, int) GetInput()
    {
        Console.WriteLine("Enter the value of A: ");
        int numOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of B: ");
        int numTwo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of C: ");
        int numThree = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of D: ");
        int numFour = Convert.ToInt32(Console.ReadLine());

        return (numOne, numTwo, numThree, numFour);
    }
}

