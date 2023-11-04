using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint4.Task1.V28.Lib;

namespace Tyuiu.MusaevRS.Sprint4.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = new int[14] { 2, 4, 4, 5, 3, 4, 4, 6, 2, 4, 5, 5, 4, 4 };
            int res = ds.Calculate(numsArray);
            int wait = 375;
            Assert.AreEqual(wait, res);
        }
    }
}
