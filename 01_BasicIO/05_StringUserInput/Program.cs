namespace StringUserInput;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your first name: ");
        string fname = Console.ReadLine();
        Console.WriteLine("Enter your last name");
        string lname = Console.ReadLine();

        Console.WriteLine("Your full name is " + fname + " " + lname);
    }
}
