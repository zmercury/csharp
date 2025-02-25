namespace o_stringEquals;

class Program
{
    static void Main(string[] args)
    {
        string passOne = "pass@123";
        string passTwo = "pass@456";
        string passThree = "pass@123";

        Boolean resultOne = passOne.Equals(passTwo);
        Boolean resultTwo = passOne.Equals(passThree);

        Console.WriteLine(resultOne);
        Console.WriteLine(resultTwo);
    }
}
