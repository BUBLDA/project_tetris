using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tetris;

namespace UnitTestTet
{
    [TestClass]
    public class UnitTest1
    {
        private MainWindow tetr;

        [TestInitialize]
        public void Setup()
        {
            tetr = new MainWindow();
        }

        [TestMethod]
        public void Test_MainWindow_OpenClose()
        {
            tetr.Show();
            Assert.IsTrue(tetr.IsVisible, "Главное окно должно быть открыто.");
            tetr.Close();
            Assert.IsFalse(tetr.IsVisible, "Главное окно должно быть закрыто.");
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (tetr != null)
            {
                tetr.Close();
            }
        }
    }
}

