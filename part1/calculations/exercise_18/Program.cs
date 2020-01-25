using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.Write("Give the first number!\n");
      String userinput1 = Console.ReadLine();
      int intvalue1 = Convert.ToInt32(userinput1);
      Console.Write("Give the second number!\n");
      string userinput2 = Console.ReadLine();
      int intvalue2 = Convert.ToInt32(userinput2);
      Console.Write("Give the third number!\n");
      string userinput3 = Console.ReadLine();
      int intvalue3 = Convert.ToInt32(userinput3);
      int sum = intvalue1 + intvalue2 + intvalue3;
      Console.WriteLine("The sum is " + sum);

    }
  }
}
