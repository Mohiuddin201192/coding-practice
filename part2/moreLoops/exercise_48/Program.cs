using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

     
      int sum = 0;
      Console.WriteLine("Give numbers:");
      while (true)

      { 
        
        int num = Convert.ToInt32(Console.ReadLine());
        if (num ==-1)
      {
        Console.WriteLine("thx! Bye!");
        break;
      }
      else
      {
        sum += num;
        num++;
        
      }
      
      }
      Console.WriteLine(" sum: " + sum);
      
      



    }
  }
}
