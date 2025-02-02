namespace _02_Switch;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number from 1 to 7: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thrusday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Satuday");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }

    }
}
