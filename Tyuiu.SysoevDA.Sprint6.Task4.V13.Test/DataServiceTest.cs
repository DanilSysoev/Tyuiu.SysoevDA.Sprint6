using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint6.Task4.V13.Lib;
namespace Tyuiu.SysoevDA.Sprint6.Task4.V13.Test
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
            valueWaitArray[0] = -9.10;
            valueWaitArray[1] = 1.55;
            valueWaitArray[2] = 292.78;
            valueWaitArray[3] = -0.57;
            valueWaitArray[4] = -0.35;
            valueWaitArray[5] = 2.00;
            valueWaitArray[6] = 4.35;
            valueWaitArray[7] = 4.57;
            valueWaitArray[8] = -288.78;
            valueWaitArray[9] = 2.45;
            valueWaitArray[10] = 13.10;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}