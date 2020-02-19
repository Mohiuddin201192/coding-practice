using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      DivisibleByThreeInRange(10, 20);

    }

    // Write your method here:
    public static void DivisibleByThreeInRange(int numerator, int denom)
    {
      while (numerator <= denom)
      {
        if (numerator % 3 ==0)
        {
          Console.WriteLine(numerator);
        }
        numerator++;
      }

    }

  }
}
