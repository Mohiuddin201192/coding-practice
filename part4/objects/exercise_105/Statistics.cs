namespace exercise_105
{
  public class Statistics
  {
    public int count { get; set; }
    public int sum { get; set; }

    public Statistics()
    {
      this.count = 0;
      this.sum = 0;
    }

    public void AddNumber(int number)
    {
      this.count = this.count + 1;
      sum = sum + number;
      
    }
  }
}