using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint6.Task1.V17.Lib;

namespace Tyuiu.SysoevDA.Sprint6.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = (stopValue - startValue) + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = 4.34;
            valueWaitArray[1] = 4.16;
            valueWaitArray[2] = 3.71;
            valueWaitArray[3] = 3.27;
            valueWaitArray[4] = 2.93;
            valueWaitArray[5] = 2.50;
            valueWaitArray[6] = 0.71;
            valueWaitArray[7] = -47.61;
            valueWaitArray[8] = 55.15;
            valueWaitArray[9] = 45.17;
            valueWaitArray[10] = 14.97;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
