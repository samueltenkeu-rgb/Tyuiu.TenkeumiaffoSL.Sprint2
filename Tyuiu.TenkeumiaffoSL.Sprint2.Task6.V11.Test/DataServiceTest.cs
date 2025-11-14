using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TenkeumiaffoSL.Sprint2.Task6.V11.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay_MiddleOfMonth()
        {
            DataService ds = new DataService();
            string res = ds.FindDateOfNextDay(2024, 5, 15); 
            string wait = "16.05.2024";
            Assert.AreEqual(wait, res);
        }


    }
}