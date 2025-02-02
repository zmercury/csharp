namespace _06_ReferenceTypeObject;

class Program
{
    static void Main(string[] args)
    {
        // declaring obj

        object obj;
        obj = 45;

        Console.WriteLine(obj);

        //Printing its type
        Console.WriteLine(obj.GetType());
    }
}
