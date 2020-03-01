using System;
using System.IO;

namespace exercise_116
{
  class Program
  {
    public static void Main(string[] args)
    {
      
      string data = File.ReadAllText("data.txt");
      Console.WriteLine(data);
      

    }
  }
}
