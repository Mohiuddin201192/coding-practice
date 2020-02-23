using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
        private static object convert;

        public static void Main(string[] args)
    {
      // integer called oldest
      int oldest = 0;
      string name = "";

      // read from user
      while (true)
      {
      string question = Console.ReadLine();
      // break if empty
      if (question == "")
      {
        break;
      }
      // split the string into part[0] part[1]
      // split the string into name    age
      string[] parts = question.Split(",");

      // check if the age is greater than oldest
      // and convetrs part[1] into int

      if (Convert.ToInt32(parts[1]) > oldest)
      {
        oldest = Convert.ToInt32(parts[1]);
        name = parts[0];
      }
      
    }
    Console.WriteLine("Name of the oldest: " + name);
    }
    
    
  }
  
}



