
namespace exercise_121
{
    public class FitByte
    {
        private int age;
        private int restingHeartRate;

        public FitByte(int age, int restingHeartRate)
        {
            this.age = age;
            this.restingHeartRate = restingHeartRate;
        }
        public double TargetHeartRate(double percentageOfMaximum)
        {
            double maxHeartRate = 206.3 - (0.711 * this.age);
            return (maxHeartRate - this.restingHeartRate) * percentageOfMaximum + this.restingHeartRate;
        }

    }
}