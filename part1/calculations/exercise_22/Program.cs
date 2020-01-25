using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give the first number!");
      string num1 = Console.ReadLine();
      int value1 = Convert.ToInt32(num1);

      Console.WriteLine("Give the second number!");
      string num2 = Console.ReadLine();
      int value2 = Convert.ToInt32(num2);

      Console.WriteLine("Give the third number!");
      string num3 = Console.ReadLine();
      int value3 = Convert.ToInt32(num3);

      double average = (value1 + value2 + value3) / 3.0;

      Console.WriteLine("The average is " + average);

    }
  }
}
