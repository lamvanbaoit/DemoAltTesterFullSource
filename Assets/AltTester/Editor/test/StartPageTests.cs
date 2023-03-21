using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Altom.AltDriver;
using Assets.AltTester.Editor.pages;
using NUnit.Framework;

namespace Assets.AltTester.Editor.test
{
    public class StartPageTests
    {
        AltDriver altDriver;
        StartPage startPage;
        MainMenuPage mainMenuPage;

        [SetUp]
        public void Setup()
        {
            altDriver = new AltDriver();
            startPage = new StartPage(altDriver);
            startPage.Load();
            mainMenuPage = new MainMenuPage(altDriver);
        }

        [Test]
        public void TestStartPageLoadedCorrectly()
        {
            Assert.True(startPage.IsDisplayed());
            startPage.Load();
            // lỗi
            //Assert.AreEqual("Run!", startPage.GetStartButtonText);
        }

        [Test]
        public void TestStartButtonLoadMainMenu()
        {
           
            startPage.PressStart();
            Assert.True(mainMenuPage.IsDisplayed());
        }

        [TearDown]
        public void Dispose()
        {
            altDriver.Stop();
            Thread.Sleep(1000);
        }
    }
}
