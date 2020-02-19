using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {


      int value = Convert.ToInt32(Console.ReadLine());
    while(true)
    {
      Console.WriteLine(value);
      if (value >= 100)
      {
        break;
      }
      value = value + 1;
      
      }

    }
  }
}
