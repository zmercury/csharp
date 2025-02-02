namespace _08_Array2D;

class Program
{
    static void Main(string[] args)
    {
        int[,] a = new int[5, 2]
        {
            {0,0},
            {3,2},
            {8,6},
            {4,3},
            {7,8}
        };

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
            }
        }
    }
}
