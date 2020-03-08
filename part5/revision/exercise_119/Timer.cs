namespace exercise_119
{

public class Timer
{
  private ClockHand seconds;
  private ClockHand hundredths;

 public Timer()
 {
     this.hundredths = new ClockHand(100);
     this.seconds = new ClockHand(60);
 }

  public void Advance()
  {
    this.hundredths.Advance();

    if (this.hundredths.value == 0)
    {
      this.seconds.Advance();

      
    }
  }

  public override string ToString()
  {
    return seconds + ":" + hundredths;
  }
}
}