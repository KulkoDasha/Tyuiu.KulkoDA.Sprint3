using Tyuiu.KulkoDA.Sprint3.Task2.V27.Lib;

namespace Tyuiu.KulkoDA.Sprint3.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int i = 1;
            int y = 14;
            int x = 5;
            double sum = ds.GetSumSeries(x,i,y);
            Assert.AreEqual(0.69,sum);
        }
    }
}