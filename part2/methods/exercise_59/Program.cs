using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Greatest(2, 7, 3);
      Console.WriteLine("Greatest: " + answer);
    }

    // Write your method here:
    public static int Greatest(int num1, int num2, int num3)
    {
      
      int ans = 0;
      if (num1 > num2 && num1 > num3)
      {
        ans = num1;
      }
      else if (num2 > num1 && num2 > num3)
      {
        ans = num2;
      }
      else
      {
        ans = num3;
      }
      return ans;
    }

  }
}
