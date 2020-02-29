using System;
namespace exercise_107
{
  public class PaymentCard
  {
    private double balance;     

    public PaymentCard(double openingBalance)
    {
      this.balance = openingBalance;
    }
    public void EatLunch()
    {
        this.balance = this.balance - 10.60;   
    }
    public void DrinkCoffee()
    {
        this.balance = this.balance - 2.0;
    }  

    public override string ToString()
    {
      return "The card has a balance of " + this.balance + " euros";
    }
  }
}