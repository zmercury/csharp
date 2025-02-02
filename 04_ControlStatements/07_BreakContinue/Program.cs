namespace _07_BreakContinue;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i < 15; i++)
        {
            if (i == 2)
            {
                continue;
            }

            if (i == 5)
            {
                break;
            }

            Console.WriteLine(i);
        }
    }
}
