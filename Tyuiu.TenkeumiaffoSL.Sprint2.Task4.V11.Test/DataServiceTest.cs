using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TenkeumiaffoSL.Sprint2.Task4.V11.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint2.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateConditionTrue()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);

            // Проверяем условие: 10 - 40 < 5 + 4 → -30 < 9 → true
            // z = (3 + 8/100)^5 = (3 + 0.08)^5 = 3.08^5 ≈ 277.102
            double wait = 277.175;
            Assert.AreEqual(wait, res);
        }

    
    }
}