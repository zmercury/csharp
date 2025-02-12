namespace d_pConstructor;

class Program
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Program(string fn, string ln)
    {
        FirstName = fn;
        LastName = ln;
    }

    static void Main(string[] args)
    {
        Program pp = new Program("Ram", "Thapa");
        Console.WriteLine(pp.FirstName + " " + pp.LastName);
    }
}
