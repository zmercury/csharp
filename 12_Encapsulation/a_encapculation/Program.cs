namespace a_encapculation;

class Student
{
    private int roll;

    public int DisplayRoll(int a)
    {
        roll = a;
        return roll;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        Console.WriteLine("Roll = " + s1.DisplayRoll(20));
    }
}
