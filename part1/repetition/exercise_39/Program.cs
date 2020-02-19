using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      while (true)
      {
        Console.WriteLine("Give a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num == 0)
        {
          break;
        }
        else
        {
          sum = sum + num;
        }

      }
      Console.WriteLine("Total sum of numbers: " + sum);
    }
  }
}
