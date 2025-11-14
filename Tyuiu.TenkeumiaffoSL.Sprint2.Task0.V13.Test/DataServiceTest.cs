using Tyuiu.TenkeumiaffoSL.Sprint2.Task0.V13.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint2.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1905;
            int y = 475;
            bool[] res = ds.GetCompareOperations(x, y);
            bool[] wait = { false, true, false, true, false, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}