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
    
    while (num > 0)  
    {
      Console.WriteLine(num);
      num--;
    }
    }








  }
}
