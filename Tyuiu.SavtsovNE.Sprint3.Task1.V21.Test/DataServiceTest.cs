using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SavtsovNE.Sprint3.Task1.V21.Lib;
namespace Tyuiu.SavtsovNE.Sprint3.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 0;
            int startValue = 1;
            int stopValue = 20;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 99.512;
            Assert.AreEqual(wait, res);
        }
    }
}