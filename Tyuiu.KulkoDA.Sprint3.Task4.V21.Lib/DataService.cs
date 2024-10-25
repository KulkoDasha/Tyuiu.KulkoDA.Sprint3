using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KulkoDA.Sprint3.Task4.V21.Lib
{
    public class DataService : ISprint3Task4V21
    {
        public double Calculate(int startValue, int stopValue)
        {
            double count = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                count = count * (Math.Cos(x) - x) / x;
                if(x==0)
                {
                    continue;
                }

            }
            return count;

        }
    }
}
