using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.Write("Give the first number!\n");
      string userinput = Console.ReadLine();
      int intvalue1 = Convert.ToInt32(userinput);
      Console.Write("Give the second number!\n");
      string userinput1 = Console.ReadLine();
      int intvalue2 = Convert.ToInt32(userinput1);
      int sum = (intvalue1 + intvalue2);
      Console.WriteLine("The sum is " + sum);


    



    }
  }
}
