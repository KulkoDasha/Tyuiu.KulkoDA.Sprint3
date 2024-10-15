using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KulkoDA.Sprint3.Task1.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            while (startValue <= stopValue)
            {
                sum += (Math.Pow(value, startValue) + 5 / (startValue + 4)) * Math.Sin(value);
                startValue++;
            }
            return Math.Round(sum,3);
        }
    }
}
