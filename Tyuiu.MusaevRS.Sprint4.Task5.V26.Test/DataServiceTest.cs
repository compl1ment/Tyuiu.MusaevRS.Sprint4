using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint4.Task5.V26.Lib;

namespace Tyuiu.MusaevRS.Sprint4.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[,] { { 7, 9, 7, -8, 6 }, { 4, 4, -4, 8, 6 }, { 7, 9, 6, 7, -6 }, { 7, 5, 4, 9, -8 }, { 9, -6, 4, 9, 8 } };
            int[,] MatrixRes = ds.Calculate(matrix);
            int[,] MatrixWait = new int[,] { { 1, 1, 1, -8, 1, }, { 1, 1, -4, 1, 1 }, { 1, 1, 1, 1, -6 }, { 1, 1, 1, 1, -8 }, { 1, -6, 1, 1, 1 } };
            CollectionAssert.AreEqual(MatrixWait, MatrixRes);
        }
    }
}
