using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SysoevDA.Sprint6.Task6.V18.Lib;

namespace Tyuiu.SysoevDA.Sprint6.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            var path = @"C:\DataSprint6\InPutFileTask6V18.txt";
            var res = ds.CollectTextFromFile("n",path);
            string wait = "VAYYbnhDwTg sNnk CMmHkUlnNoZen nqrB";
            Assert.AreEqual(wait, res);
        }
    }
}
