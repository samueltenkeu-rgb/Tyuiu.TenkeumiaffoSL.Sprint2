using Tyuiu.TenkeumiaffoSL.Sprint2.Task2.V13.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint2.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea1()
        {
            DataService ds = new DataService();
            // Точка в заштрихованной области: строка 2, столбец 4
            Assert.IsTrue(ds.CheckDotInShadedArea(4, 2));
        }

      
    }
}