using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
    }

    // Write your method here:
    public static int Smallest(int num1, int num2)
    {
      int small = 0;
      if (num1 < num2)
      {
        small = num1;
      }
      else
      {
        small = num2;
      }
      return small;

    }
    
  }
}
