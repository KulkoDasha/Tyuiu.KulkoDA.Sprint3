using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KulkoDA.Sprint3.Task1.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double t = value;
            double k = startValue;
            double sum = 0;
            while (k <= stopValue)
            {
                sum = sum + (Math.Pow(t,k)+ 5/(k+4))*Math.Sin(t);
                k++;
            }
            return Math.Round(sum,3);
        }
    }
}
