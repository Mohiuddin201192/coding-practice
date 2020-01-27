using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

    
    
    int value = Convert.ToInt32(Console.ReadLine());
    while(true)
    {
      Console.WriteLine(value);
      if (value >= 4)
      {
        break;
      }
      value = value + 1;
      
    }
    
    
    }
  }
}
