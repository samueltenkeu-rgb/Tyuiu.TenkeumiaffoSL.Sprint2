using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TenkeumiaffoSL.Sprint2.Task7.V3.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCenterPoint()
        {
            DataService ds = new DataService();

            bool res = ds.CheckDotInShadedArea(0, 0.5);

            Assert.IsTrue(res);
        }


    }
}