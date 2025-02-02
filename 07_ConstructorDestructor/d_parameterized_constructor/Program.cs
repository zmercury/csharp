namespace d_parameterized_constructor;

class Student
{
    int roll;
    string name;
    string address;
    public Student(int r, string n, string a){
        roll = r;
        name = n;
        address = a;
    }
    public void displayInfo()
    {
        Console.WriteLine("Roll number of " + name + " is " + roll + " and lives in " + address);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(420, "Ram Thapa", "Ghopteodar");
        s1.displayInfo();
    }
}
