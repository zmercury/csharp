namespace c_pConstructor;

class Car
{
    string name;
    int price;

    public Car(string n, int p)
    {
        name = n;
        price = p;
    }

    public void displayDetail()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Price: " + price);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car cc = new Car("Honda rs", 500000);
        cc.displayDetail();
    }
}
