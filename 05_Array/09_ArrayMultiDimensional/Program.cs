namespace i_array_multidimensional_jagged;

class Program
{
    static void Main(string[] args)
    {
        int[][] myarray = new int[3][];
        myarray[0] = new int[3] { 56, 78, 34 };
        myarray[1] = new int[5] { 44, 23, 90, 8, 9 };
        myarray[2] = new int[2] { 12, 22 };

        foreach (int[] i in myarray)
        {
            foreach (int item in i)
            {
                Console.WriteLine(item);
            }
        }
    }
}
