using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint4.Task0.V22.Lib;

namespace Tyuiu.MusaevRS.Sprint4.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] ArrayRes;
            ArrayRes = new int[] { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int wait = 46;
            int res = ds.GetSumOddArrEl(ArrayRes);
            Assert.AreEqual(wait, res);
        }
    }
}
