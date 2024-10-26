using Tyuiu.KulkoDA.Sprint3.Task7.V2.Lib;
namespace Tyuiu.KulkoDA.Sprint3.Task7.V2.Test
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
            int len = z - a+1;
            double[] mass;
            mass = new double[len];
            mass[0] = 59.49;
            mass[1] = 38.47;
            mass[2] = -2.81;
            mass[3] = -19.67;
            mass[4] = -8.42;
            mass[5] = 0.57;
            mass[6] = -6.30;
            mass[7] = -20.14;
            mass[8] = -3.51;
            mass[9] = 38.13;
            mass[10] = 59.60;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(a, z);
            CollectionAssert.AreEqual(mass, res);
        }
    }
}