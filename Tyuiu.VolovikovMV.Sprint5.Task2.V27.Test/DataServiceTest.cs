using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VolovikovMV.Sprint5.Task2.V27.Lib;

namespace Tyuiu.VolovikovMV.Sprint5.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\volov\source\repos\Tyuiu.VolovikovMV.Sprint5\Tyuiu.VolovikovMV.Sprint5.Task2.V27\bin\Debug\OutPutFileTask2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
