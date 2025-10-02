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
            double res = ds.Calculate(x);
            // 5 - 12*5 + cos(5) = 5 - 60 + 0.2837 = -54.7163 → -54.716    
            Assert.AreEqual(-54.716, res);
        } 


    }
}