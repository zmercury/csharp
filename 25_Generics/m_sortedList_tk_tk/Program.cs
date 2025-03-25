namespace m_sortedList_tk_tk;

#nullable disable

using System;

class Program
{
  static void Main(string[] args)
  {
    SortedList<int, string> rollnames = new SortedList<int, string>();
    rollnames.Add(1, "Ram");
    rollnames.Add(7, "Hari");
    rollnames.Add(9, "Sita");
    rollnames.Add(2, "Gita");
    rollnames.Add(3, null);
    rollnames.Add(6, "Sabin");
    rollnames.Add(8, "Badal");

    rollnames[3] = "john";
    rollnames[2] = "sita";

    /*
    foreach (var items in rollnames)
    {
      Console.WriteLine("Key is {0} and value is {1}", items.Key, items.Value);
    }
    */

    rollnames.ToList().ForEach(items => Console.WriteLine("Key is {0} and value is {1}", items.Key, items.Value));
  }
}
