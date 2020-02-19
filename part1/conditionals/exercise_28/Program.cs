using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("How old are you?");
      string number = Console.ReadLine();
      int age = Convert.ToInt32(number);
      if (age < 18)
      {
        Console.WriteLine("You're under age!");
      }
      else
      {
        Console.WriteLine("You're an adult!");
      }

    }
  }
}
