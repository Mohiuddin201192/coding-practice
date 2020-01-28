using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Where to?");
      int num = Convert.ToInt32(Console.ReadLine());
      for (num = 0; num < 10; num++)
      {
        Console.WriteLine(num);
      }
      Console.WriteLine("Where from?");
      int num1 = Convert.ToInt32(Console.ReadLine());
      for (num1 = 0; num1 > 10; num1++)
      {
        Console.WriteLine(num1);
      }
      
      
      
    }
  }
}
