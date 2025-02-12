namespace b_interface;

interface IStudent
{
    public void learn();
}

interface ITeacher
{
    public void teaches();
}

class College : IStudent, ITeacher
{
    public void learn()
    {
        Console.WriteLine("Student is learning!");
    }

    public void teaches()
    {
        Console.WriteLine("Teacher is teaching!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        College cg = new College();

        cg.learn();
        cg.teaches();
    }
}
