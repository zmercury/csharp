namespace _05_ClassObject;

#nullable disable

class Student
{
    public int roll;
    public string name;

    public void input(int r, string n)
    {
        roll = r;
        name = n;
    }

    public void output()
    {
        Console.WriteLine("Roll = " + roll);
        Console.WriteLine("Name = " + name);
    }
}

class StudentDemo
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        Student s2 = new Student();

        s1.input(420, "hello");
        s2.input(234, "World");

        s1.output();
        s2.output();
    }
}
