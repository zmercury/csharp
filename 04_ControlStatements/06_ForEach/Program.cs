namespace _06_ForEach;

class Program
{
    static void Main(string[] args)
    {
        char[] myArr = { 'H', 'E', 'L', 'L', 'O' };

        foreach (var item in myArr)
        {
            Console.WriteLine(item);
        }
    }
}
