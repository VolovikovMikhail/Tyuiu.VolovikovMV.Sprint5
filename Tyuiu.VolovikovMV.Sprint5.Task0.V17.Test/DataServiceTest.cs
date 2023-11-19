using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VolovikovMV.Sprint5.Task0.V17.Lib;

namespace Tyuiu.VolovikovMV.Sprint5.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\volov\source\repos\Tyuiu.VolovikovMV.Sprint5\Tyuiu.VolovikovMV.Sprint5.Task0.V17\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
