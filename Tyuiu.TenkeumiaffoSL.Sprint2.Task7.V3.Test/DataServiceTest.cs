using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TenkeumiaffoSL.Sprint2.Task7.V3.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea_Center()
        {
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(0, 0.5);
            // Центр заштрихованной области - (0, 0.5)
            // Внутри окружности: 0 + (0.5-1)² = 0.25 <= 1 ✓
            // Ниже параболы: 0.5 <= 1 - 0 = 1 ✓
            Assert.IsTrue(res);
        }


    }
}