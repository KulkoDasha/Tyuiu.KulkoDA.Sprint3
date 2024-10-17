using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KulkoDA.Sprint3.Task2.V27.Lib
{
    public class DataService : ISprint3Task2V27
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            int i = startValue;
            int x =value;
            double sum = 0;
            do 
            {
                sum = sum + Math.Pow((4/(1+ Math.Pow(x,i))), i);
                i++;
            }while (i <= stopValue);
            return Math.Round(sum,3);
        }
    }
}
