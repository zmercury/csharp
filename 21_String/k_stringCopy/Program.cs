namespace k_stringCopy;

class Program
{
    static void Main(string[] args)
    {
        string message = "Hello World!";
        // string messageTwo = string.Copy(message); //not recommended

        string messageTwo = new string(message);

        Console.WriteLine(message);
        Console.WriteLine(messageTwo);
    }
}
