using Tyuiu.KulkoDA.Sprint3.Task0.V23.Lib;

namespace Tyuiu.KulkoDA.Sprint3.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int c = 100;
            int y = 1;
            double x = 1.5;
            var res = ds.GetSumSeries(x, y, c);
            Assert.AreEqual(0.298, res);

        }
    }
}