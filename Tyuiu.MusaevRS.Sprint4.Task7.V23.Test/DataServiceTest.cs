using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint4.Task7.V23.Lib;

namespace Tyuiu.MusaevRS.Sprint4.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "678135972514";
            int rows = 4;
            int colums = 3;
            int res = ds.Calculate(rows, colums, value);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
