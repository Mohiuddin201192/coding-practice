using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
      string num1 = Console.ReadLine();
      int first = Convert.ToInt32(num1);

      Console.WriteLine("Give the second number!");
      string num2 = Console.ReadLine();
      int second = Convert.ToInt32(num2);

      if (first > second)
      {
        Console.WriteLine("The larger number is " + first + "!");
      }
      else if (first == second)
      {
        Console.WriteLine("They are equal!");
      }
      else

      {
        Console.WriteLine("The larger number is " + second + "!");
      }


    }
  }
}
