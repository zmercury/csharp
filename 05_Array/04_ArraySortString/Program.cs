namespace _04_ArraySortString;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "ram", "sita", "hari" };

        int len = names.Length;

        Array.Sort(names);
        Array.Reverse(names);

        Console.WriteLine("The length is " + len);

        foreach (var items in names)
        {
            Console.WriteLine(items);
        }
    }
}
