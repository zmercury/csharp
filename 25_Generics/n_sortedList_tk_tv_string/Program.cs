namespace n_sortedList_tk_tv_string;

#nullable disable

using System;

class Program
{
  static void Main(string[] args)
  {
    SortedList<string, string> cities = new SortedList<string, string>(){
      {"Nepal", "Kathmandu"},
      {"India", "New Delhi"},
      {"Japan", "Tokyo"},
    };

    cities.ToList().ForEach(items => Console.WriteLine($"Key is {items.Key} and value is {items.Value}"));
  }
}
