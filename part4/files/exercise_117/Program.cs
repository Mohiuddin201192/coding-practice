using System;
using System.IO;

namespace exercise_117
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Which file should have its contents printed?");

      string input = Console.ReadLine();
      string [] lines = File.ReadAllLines(input);
      foreach (string line in lines)
      {
        Console.WriteLine(line);
      }
      
     /*  if (input == "data.txt")
      {
        string data = File.ReadAllText("data.txt");
        Console.WriteLine(data);
      } 
      if (input == "song.txt")
      {
        string song = File.ReadAllText("song.txt");
        Console.WriteLine(song);
      } */
      
    }
  }
}
