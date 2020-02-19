using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
      int negative = 0;
      while (true)
      {
        Console.WriteLine("Give a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num == 0)
        {
          break;
        }
        if (num < 0)
        {
          negative = negative + 1;
        }

      }
      Console.WriteLine("Total amount of negative numbers: " + negative);

    }
  }
}
