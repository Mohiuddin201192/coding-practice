using System;

namespace exercise_57
{
  class Program
  {
    public static int Sum(int number1, int number2, int number3, int number4)
    {
      // write your code here
      int sum = number1 + number2 + number3 + number4;
      // remember to include return (at the end)!
      return sum;
    }

    public static void Main(String[] args)
    {
      int answer = Sum(4, 3, 6, 1);
      Console.WriteLine("Sum: " + answer);
    }
  }
}
