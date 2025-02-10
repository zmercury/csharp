namespace c_overloading;

class MyClass
{
    public void DisplayDetail(int a, string b)
    {
        Console.WriteLine(b + " is " + a + " years old");
    }

    public void DisplayDetail(string a, int b)
    {
        Console.WriteLine(a + " is " + b + " years old");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass my = new MyClass();

        my.DisplayDetail(10, "Badal");
        my.DisplayDetail("Badal", 20);
    }
}


