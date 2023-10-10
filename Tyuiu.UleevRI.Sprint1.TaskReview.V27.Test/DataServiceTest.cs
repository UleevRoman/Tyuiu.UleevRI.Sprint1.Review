using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint1.TaskReview.V27.Lib;

namespace Tyuiu.UleevRI.Sprint1.TaskReview.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = -3.597;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
