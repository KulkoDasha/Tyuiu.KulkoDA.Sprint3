using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KulkoDA.Sprint3.Task5.V25.Lib
{
    public class DataService : ISprint3Task5V25
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            
            double sum = 0;
            do
            {
                do
                {
                    sum = sum + Math.Pow(x, startValue2) + Math.Cos(startValue2);
                    startValue2++;
                } while (startValue2 <= stopValue2);
                startValue1++;
            } while (startValue1 <= stopValue1);
            return Math.Round(sum, 3);
        }
    }
}
