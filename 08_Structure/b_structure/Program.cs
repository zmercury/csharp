namespace b_structure;

struct Student
{
    public int roll;
    public string name;
    public int age;
    public string address;
    public string phone;
}
class Program
{
    static void Main(string[] args)
    {
        Student s1;
        Student s2;

        s1.roll = 11;
        s1.name = "Ram Thapa";
        s1.age = 23;
        s1.address = "Pokhara";
        s1.phone = "1234567890";

        s2.roll = 15;
        s2.name = "Sita Rai";
        s2.age = 22;
        s2.address = "Kathmandu";
        s2.phone = "539827543";


        Console.WriteLine("Student One Roll  = " + s1.roll);
        Console.WriteLine("Student One Name  = " + s1.name);
        Console.WriteLine("Student One Age  = " + s1.age);
        Console.WriteLine("Student One Address  = " + s1.address);
        Console.WriteLine("Student One Phone  = " + s1.phone);

        Console.WriteLine();

        Console.WriteLine("Student Two Roll  = " + s2.roll);
        Console.WriteLine("Student Two Name  = " + s2.name);
        Console.WriteLine("Student Two Age  = " + s2.age);
        Console.WriteLine("Student Two Address  = " + s2.address);
        Console.WriteLine("Student Two Phone  = " + s2.phone);
    }
}
