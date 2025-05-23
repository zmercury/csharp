namespace _01_one;

  class Program
  {
    enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

    static void Main(string[] args)
    {
      //int lastDay = (int)Days.Saturday;
      //Console.WriteLine(lastDay);

      //var wd = (Days)5;
      //Console.WriteLine(wd);

      var today = (Days)6;

      if (today == Days.Saturday || today == Days.Friday)
      {
        Console.WriteLine("Let's have fun");
      }
      else
      {
        Console.WriteLine("Word Day");
      }



      Console.WriteLine("Enter your name: ");
      string name = Console.ReadLine();

      Console.WriteLine($"Hello {name}, Today is {today}");
    }
  }
