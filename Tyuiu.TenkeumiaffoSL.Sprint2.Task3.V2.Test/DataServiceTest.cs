using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            double x = 5.0;

            // 5 - 60 + cos(5) = -55 + 0.28366 = -54.71634 → -54.716
            double res = ds.Calculate(x);

            Assert.AreEqual(-54.716, res);
        }
    }
}
