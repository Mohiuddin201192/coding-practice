using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num = 0;

            while(true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                num = num + 1;
            }
            Console.WriteLine(num);
        }
    }
}
