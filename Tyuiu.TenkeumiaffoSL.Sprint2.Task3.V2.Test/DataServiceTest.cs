using Tyuiu.TenkeumiaffoSL.Sprint2.Task3.V2.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint2.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateXGreaterThan3()
        {
            DataService ds = new DataService();
            double x = 4.0;
            double res = ds.Calculate(x);
            // 4 - 12*4 + cos(4) = 4 - 48 + (-0.6536) = -44.6536 → -44.7
            Assert.AreEqual(-44.7, res);
        }
    }
}