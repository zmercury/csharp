namespace a_defaultConstructor;

class Student
{
    public Student()
    {
        Console.WriteLine("Hello World!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        new Student();
    }
}
