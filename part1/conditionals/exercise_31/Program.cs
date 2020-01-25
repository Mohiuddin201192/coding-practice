using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      string number = Console.ReadLine();
      int calc = Convert.ToInt32(number);
      if ((calc % 2) ==0)
      {
        Console.WriteLine("It is even.");
      }
      else
      {
        Console.WriteLine("It is odd.");
      }
    }
  }
}
