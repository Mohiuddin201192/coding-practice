using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      int num1 = Convert.ToInt32(Console.ReadLine());
      int num2 = Convert.ToInt32(Console.ReadLine());
      double sqrt = Math.Sqrt(num1 + num2);
      Console.WriteLine(sqrt);
    
    }
  }
}
