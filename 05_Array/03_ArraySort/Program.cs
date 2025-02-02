namespace _03_ArraySort;

class Program
{
    static void Main(string[] args)
    {
        int[] myArr = { 1, 2, 56, 3, 5, 7, 7, 34, 3, 34, 5, 6, 23, 123, 56, 745, 4 };

        Array.Sort(myArr);
        foreach (var item in myArr)
        {
            Console.WriteLine(item);
        }

        Array.Reverse(myArr);
        foreach (var item in myArr)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("min" + myArr.Min());
        Console.WriteLine("max" + myArr.Max());
        Console.WriteLine("sum" + myArr.Sum());
        Console.WriteLine("average" + myArr.Average());
    }
}
