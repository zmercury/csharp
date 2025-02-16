// Demonstrate the use of interface for basic arithmetic operations on two user input
namespace _02_InterfaceArith;
using System;

public interface IArithmetic
{
    public int add(int a, int b);
    public int sub(int a, int b);
    public int div(int a, int b);
    public int mul(int a, int b);
}

class Program : IArithmetic
{
    public int add(int a, int b)
    {
        return a + b;
    }

    public int sub(int a, int b)
    {
        if (a > b)
        {
            return (a - b);
        }
        else
        {
            return (b - a);
        }
    }

    public int div(int a, int b)
    {
        if (a > b)
        {
            return (a / b);
        }
        else
        {
            return (b / a);
        }
    }

    public int mul(int a, int b)
    {
        return (a * b);
    }

    static void Main(string[] args)
    {
        IArithmetic ar = new Program();

        Console.WriteLine("Enter the value of a: ");
        int numOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of b: ");
        int numTwo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sum = " + ar.add(numOne, numTwo));
        Console.WriteLine("Substraction = " + ar.sub(numOne, numTwo));
        Console.WriteLine("Division = " + ar.div(numOne, numTwo));
        Console.WriteLine("Multiplication = " + ar.mul(numOne, numTwo));
    }
}
