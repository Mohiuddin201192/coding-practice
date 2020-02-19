using System;

namespace exercise_20
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give the first number!");
      string me1 = Console.ReadLine();
      int value1 = Convert.ToInt32(me1);
      
      Console.WriteLine("Give the second number!");
      string me2 = Console.ReadLine();
      int value2 = Convert.ToInt32(me2);

      int sum = value1 * value2;

      Console.WriteLine(me1 + " * " + me2 + " = " + sum);



    }
  }
}
