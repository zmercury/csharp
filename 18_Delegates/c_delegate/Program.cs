namespace c_delegate;

delegate int NumberCalc(int num);

class Program
{
    static int num = 10;

    public static int AddNum(int a)
    {
        num += a;
        return num;
    }

    public static int MulNum(int a)
    {
        num *= a;
        return num;
    }

    public static int GetNum(int a)
    {
        return num;
    }

    static void Main(string[] args)
    {
        NumberCalc nl = new NumberCalc(AddNum);
        nl(5);
        Console.WriteLine("New Value = {0}", GetNum());
    }
}
