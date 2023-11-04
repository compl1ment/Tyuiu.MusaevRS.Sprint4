using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint4.Task3.V14.Lib;

namespace Tyuiu.MusaevRS.Sprint4.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int wait = 7;
            int[,] array = new int[5, 5] { { 3, 2, 3, 3, 5 },
                                           { 2, 3, 3, 7, 3 },
                                           { 7, 5, 2, 7, 3 },
                                           { 4, 2, 7, 5, 2 },
                                           { 3, 5, 4, 2, 6 } };

            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
