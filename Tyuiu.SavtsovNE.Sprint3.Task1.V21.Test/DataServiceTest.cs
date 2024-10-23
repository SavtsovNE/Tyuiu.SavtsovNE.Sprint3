using Tyuiu.SavtsovNE.Sprint3.Task1.V21.Lib;
using Tyuiu.SavtsovNE.Sprint3.Task1.V21.Test;

namespace Tyuiu.SavtsovNE.Sprint3.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 12;
            double res = 16947810.881;
            Assert.AreEqual(res, ds.GetMultiplySeries(value, startValue, stopValue));
        }
    }
}