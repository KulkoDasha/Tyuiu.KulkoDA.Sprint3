using Tyuiu.KulkoDA.Sprint3.Task3.V2.Lib;

namespace Tyuiu.KulkoDA.Sprint3.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string c= "asdzzz vfvfzz v gthvz";
            char ch = 'z';
            var res = ds.GetMaxCharCount(c,ch);
            Assert.AreEqual(3,res);
        }
    }
}