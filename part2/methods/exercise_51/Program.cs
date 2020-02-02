using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      PrintUntilNumber(5);



    }

    // Write your method here:
    public static void PrintUntilNumber(int num){
    int digit = 1;
    while (digit <= num)  
    {
      Console.WriteLine(digit);
      digit++;
    }
    }








  }
}
