using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VolovikovMV.Sprint5.Task6.V24.Lib;

namespace Tyuiu.VolovikovMV.Sprint5.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V24.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);

            double res = ds.LoadFromDataFile(path);
            double wait1 = 4;

            Assert.AreEqual(wait1, res);
        }
    }
}
