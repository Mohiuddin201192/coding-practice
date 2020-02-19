using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
      Console.WriteLine("How many times?");
      int num = Convert.ToInt32(Console.ReadLine());
      int time = 0;
      while (time < num)
      {
        PrintPhase();
        time++;
      }
 
    }

    // Write your method here:
    public static void PrintPhase() {
    }

        private static void PrintPhase1()
        {
            Console.WriteLine("In a hole in the ground there lived a method");
        }







    }
}
