namespace b_encapculation;
#nullable disable

class Student
{
    private int sroll;
    private string sname;

    public int Roll
    {
        get
        {
            return sroll;
        }
        set
        {
            sroll = value;
        }
    }

    public string Name
    {
        get
        {
            return sname;
        }
        set
        {
            sname = value;
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.Roll = 56;
        s1.Name = "hari";

        Console.WriteLine("Roll = " + s1.Roll);
        Console.WriteLine("Name = " + s1.Name);
    }
}
