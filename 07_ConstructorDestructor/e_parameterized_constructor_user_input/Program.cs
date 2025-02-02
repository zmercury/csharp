namespace e_parameterized_constructor_user_input;

class Student
{
    int roll;
    string name, address;

    public Student(int r, string n, string a)
    {
        roll = r;
        name = n;
        address = a;
    }
    public void displayInfo()
    {
        Console.WriteLine(name + " lives in " + address + " whose roll number is " + roll + ".");
    }
}
class Program
{

    static void Main(string[] args)
    {
        int sr;
        string sn, sa;
        Console.WriteLine("Enter student roll number:");
        sr = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter student name:");
        sn = Console.ReadLine();
        Console.WriteLine("Enter student address:");
        sa = Console.ReadLine();

        Student s1 = new Student(sr, sn, sa);
        s1.displayInfo();
    }
}
