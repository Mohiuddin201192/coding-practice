using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
        Console.WriteLine("Give a number:");
        string num = Console.ReadLine();
        int value = Convert.ToInt32(num);
        if (value > 0)
        {
          Console.WriteLine(value * value);
        }
        if (value < 0)
        {
          Console.WriteLine("That is negative");
        }
        if (value == 0)
        {
          break;
        }
      }

    }
  }
}
