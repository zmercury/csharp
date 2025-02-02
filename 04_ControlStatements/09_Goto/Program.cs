namespace _09_Goto;

class Program
{
    static void Main(string[] args)
    {
    ineligible:
        Console.WriteLine("You cant cast a vote");

        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age > 18)
        {
            Console.WriteLine("You can cast vote!");
        }

        else
        {
            goto ineligible;
        }

    }
}
