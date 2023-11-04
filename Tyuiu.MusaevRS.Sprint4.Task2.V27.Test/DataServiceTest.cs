using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint4.Task2.V27.Lib;

namespace Tyuiu.MusaevRS.Sprint4.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] valueArray = new int[13] { 2, 2, 3, 6, 5, 5, 4, 3, 2, 3, 4, 6, 7 };
            int wait = 26;
            int res = ds.Calculate(valueArray);
            Assert.AreEqual(wait, res);
        }
    }
}
