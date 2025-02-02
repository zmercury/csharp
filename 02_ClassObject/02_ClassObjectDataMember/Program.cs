namespace _02_ClassObjectDataMember;

#nullable disable

class Student
{
    int roll;
    string name;

    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.roll = 20;
        s1.name = "Mer";

        Console.WriteLine("Roll = " + s1.roll);
        Console.WriteLine("Name = " + s1.name);

        Console.WriteLine("Hello World!");
    }
}
