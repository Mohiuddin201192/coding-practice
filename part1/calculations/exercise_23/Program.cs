using System;

namespace exercise_23
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

      int sum = value1 + value2;
      int sum1 = value1 - value2;
      int sum3 = value1 * value2;
      double average = (value1 + value2) / 2.0;
    
      

      Console.WriteLine(value1 + " + " + value2 + " = " + sum + "\n" + value1 + " - " + value2 + " = " + sum1 + "\n" + value1 + " * " + value2  + " = " + sum3);
      Console.WriteLine(value1 + " / " + value2 + " = " + average);

    }
  }
}
