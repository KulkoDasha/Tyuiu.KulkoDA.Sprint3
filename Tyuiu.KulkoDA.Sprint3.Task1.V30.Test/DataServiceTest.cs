using Tyuiu.KulkoDA.Sprint3.Task1.V30.Lib;

namespace Tyuiu.KulkoDA.Sprint3.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double t =0.5;
            int k = 1;
            int z = 12;
            var res = ds.GetSumSeries(t, k, z);
            Assert.AreEqual(3.589, res);
        }
    }
}