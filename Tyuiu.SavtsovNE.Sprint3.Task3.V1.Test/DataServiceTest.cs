using Tyuiu.SavtsovNE.Sprint3.Task3.V1.Lib;

namespace Tyuiu.SavtsovNE.Sprint3.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = 2;
            Assert.AreEqual(varForTest, ds.GetCharCount("have a nice time", 'a'));
        }
    }
}