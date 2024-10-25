using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KulkoDA.Sprint3.Task3.V2.Lib
{
    public class DataService : ISprint3Task3V2
    {
        public int GetMaxCharCount(string value, char item)
        {
            int mx = 0;
            int k = 0;
            int count = 0;
            
            foreach (char z in value)
            {
                
                if (z == item)
                {
                    count++;
                    mx = Math.Max(mx, count);
                }
                else count = 0;
                k++;
            }
            return mx;
        }
    }
}
