namespace _06_Array;

class Program
{
    static void Main(string[] args)
    {
        int[] n = new int[10];
        int i, j;

        for (i = 0; i < 10; i++)
        {
            n[i] = i + 100;
        }

        for (j = 0; j < 10; j++)
        {
            Console.WriteLine("Elem [{0}] = {1}", j, n[j]);
        }
    }
}
