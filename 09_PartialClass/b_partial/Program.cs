namespace b_partial;
#nullable disable

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        string userInpur = s1.GetInput();
        s1.DisplayOutput(userInpur);
    }
}
