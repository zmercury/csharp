namespace _07_ArraySearchNum;

class Program
{
    static void Main(string[] args)
    {
        int[] myArr = new int[] { 12, 124, 523, 345, 645 };

        Console.WriteLine("Enter a number to search: ");
        int num = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < myArr.Length; i++)
        {
            if (num == myArr[i])
            {
                found = true;
                break;
            }
        }

        if (found == true)
        {
            Console.WriteLine("Number has been found!");
        }
        else
        {
            Console.WriteLine("Number is not in array!");
        }
    }
}
