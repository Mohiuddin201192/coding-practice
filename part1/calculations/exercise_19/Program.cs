using System;

namespace exercise_19
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.Write("Give the first number!\n");
      string me1 = Console.ReadLine();
      int value1 = Convert.ToInt32(me1);
      Console.Write("Give the second number!\n");
      string me2 = Console.ReadLine();
      int value2 = Convert.ToInt32(me2);
      int sum = value1 + value2;
      Console.WriteLine(me1 + " + " + me2 + " = " + (sum));
      



    }
  }
}
