namespace e_stringInterpolation;

class Program
{
    static void Main(string[] args)
    {
        // 1. Use of $ symbol
        /*
        var message = "Hello";
        var messageTwo = "Hi";

        var mainMessage = $"{message} and {messageTwo}";
        Console.WriteLine(mainMessage);

        var a = 5;
        var result = $"Square of {a} = {a * a}";
        Console.WriteLine(result);

        string name = "Ram";
        string msg = $"Hello {name}";
        Console.WriteLine(msg);
        */

        // Use of string Format()

        var name = "Ufufuweucu";
        var greeting = string.Format("Hello {0} {1}", name, "!");
        Console.WriteLine(greeting);
    }
}
