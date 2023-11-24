using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolstykhVS.Sprint5.Task0.V10.Lib;

namespace Tyuiu.TolstykhVS.Sprint5.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public static void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(18.4, ds.Calculate());
        }
    }
}
