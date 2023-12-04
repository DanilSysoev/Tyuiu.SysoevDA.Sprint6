using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint6.Task3.V9.Lib;
namespace Tyuiu.SysoevDA.Sprint6.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            
                DataService ds = new DataService();
                int[,] array = { { -14, 25, 26, 18, 17 },
                             { 28, 10,  6, -2, 4},
                             { 30, 25, -3, 11, -10},
                             { 11, 32, -5, -20, 25 },
                             { 2, -18, 11, 8, -20 } };
                int[,] valueWaitArray = { { -14, 25, 26, 18, 17 },
                             { 28, 10,  6, -2, 4},
                             { 30, 25, -3, 11, -10},
                             { 11, 32, -5, -20, 25 },
                             { -20, -18, 2, 8, 11 } };
                var res = ds.Calculate(array);
                CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
