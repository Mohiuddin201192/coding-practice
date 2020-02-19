using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
        Console.Write("Give a number:\n");
        string num = Console.ReadLine();
        int value = Convert.ToInt32(num);
        if (value == 42)
        {
          break;
        }
      }

    }
  }
}
