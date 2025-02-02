namespace _04_ClassObjectUserInputMethod;

#nullable disable

class Student
{
    int roll;
    string name;

    public void input()
    {
        Console.WriteLine("Enter your roll number: ");
        roll = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your name: ");
        name = Console.ReadLine();
    }

    public void output()
    {
        Console.WriteLine("Roll = " + roll + " and name = " + name);
    }

    static void Main(string[] args)
    {
        Student s1 = new Student();

        s1.input();
        s1.output();
    }
}
