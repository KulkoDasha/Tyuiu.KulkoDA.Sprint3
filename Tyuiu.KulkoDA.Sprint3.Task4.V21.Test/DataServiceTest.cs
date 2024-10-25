using Tyuiu.KulkoDA.Sprint3.Task4.V21.Lib;

namespace Tyuiu.KulkoDA.Sprint3.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = -5;
            int z = 5;
            var res = ds.Calculate(a, z);
            Assert.AreEqual(0.586, res);
        }
    }
}