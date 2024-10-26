using Tyuiu.KulkoDA.Sprint3.Task6.V5.Lib;
namespace Tyuiu.KulkoDA.Sprint3.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int i = 15;
            int k = 22;
            var res = ds.GetSumTheDivisors(i,k);
            Assert.AreEqual(242,res);
        }
    }
}