using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      
    Console.WriteLine("How many days?");
    string userInput= Console.ReadLine();
    int sec2days =86400;
    int intValue = Convert.ToInt32(userInput);
    Console.WriteLine( sec2days * intValue);

      

    }
  }
}
