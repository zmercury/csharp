namespace f_stringNameAddress;

class Program
{
    static void Main(string[] args)
    {
        string fName = "Badal";
        string lName = "Chamling Rai";
        string address = "pain";

        Console.WriteLine(fName + " " + lName + " lives in " + address);
        Console.WriteLine("{0} {1} lives in {2}", fName, lName, address);
    }
}
