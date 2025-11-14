using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TenkeumiaffoSL.Sprint2.Task5.V8.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay_MiddleOfMonth()
        {
            DataService ds = new DataService();
            int m = 5;
            int n = 15;
            string res = ds.FindDateOfPreviousDay(m, n);
            string wait = "14.05";
            Assert.AreEqual(wait, res);
        }


    }
}