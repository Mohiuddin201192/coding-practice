using System;

namespace exercise_115
{
  class Program
  {
    public static void Main(string[] args)
    {
      while(true)
    {
      string input = Console.ReadLine();
      if (input == "end")
      {
        break;
      }
      int num = Convert.ToInt32(input);
      Console.WriteLine(num * num * num);
    }
  }
  }
}
