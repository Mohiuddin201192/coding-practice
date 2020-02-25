using System;

namespace exercise_94
{
  class Program
  {
    public static void Main(string[] args)
    {   
      Account heikkisAccount = new Account ("Heikki's account", 1000.00);
      Account personalAccount = new Account ("Personal account", 0.00);

      heikkisAccount.Withdrawal(100);
      personalAccount.Deposit(100);

      Console.WriteLine(heikkisAccount);
      Console.WriteLine(personalAccount);

    }
  }
}



