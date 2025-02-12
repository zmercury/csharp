namespace a_interface;

interface INepal
{
    public void hi();
}

class Country: INepal 
{
    public void hi()
    {
        Console.WriteLine("Hi Nepal!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Country ca = new Country();
        ca.hi();
    }
}
