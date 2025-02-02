namespace _03_ClassObjectUserInput;

#nullable disable

class Student
{
    int roll;
    string name;

    static void Main(string[] args)
    {
        Student s1 = new Student();

        Console.WriteLine("Enter your roll number: ");
        s1.roll = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your name: ");
        s1.name = Console.ReadLine();

        Console.WriteLine("Roll = " + s1.roll);
        Console.WriteLine("Name = " + s1.name);
    }
}
