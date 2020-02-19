using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give the first number!");
      string userinput1 = Console.ReadLine();
      int value1 = Convert.ToInt32(userinput1);
      
      Console.WriteLine("Give the second number!");
      string userinput2 = Console.ReadLine();
      int value2 = Convert.ToInt32(userinput2);

      double average = (value1 + value2) / 2.0;
      Console.WriteLine("The average is " + average);


    }
  }
}
