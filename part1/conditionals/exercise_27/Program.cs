using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      string number = Console.ReadLine();
      int value = Convert.ToInt32(number);
      if (value >= 0)

      {
        Console.WriteLine("It is positive");
        
      }
      if (value < 0)
      {
        Console.WriteLine("It is not positive");
      }
    

    }
  }
}
