namespace i_list_t;

using System;

class Program
{
    static void Main(string[] args)
    {
      List<int> nums = new List<int>();

      nums.Add(2);
      nums.Add(4);
      nums.Add(6);
      nums.Add(8);

      nums.ForEach(nums => Console.WriteLine(nums));
    }
}
