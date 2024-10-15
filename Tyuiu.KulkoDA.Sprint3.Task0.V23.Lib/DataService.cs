using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KulkoDA.Sprint3.Task0.V23.Lib
{
    public class DataService : ISprint3Task0V23
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum11 = 0;
            int k;
            for (k=startValue; k <= stopValue; k++)
            {
                sum11 += Math.Pow(1/(Math.Sin(k)+2*Math.Pow(value,k)), k);
            }
            return Math.Round(sum11,3);
        }
    }
}
