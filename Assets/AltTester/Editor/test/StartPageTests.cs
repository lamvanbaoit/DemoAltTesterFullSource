﻿using System;
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

        [TearDown]
        public void Dispose()
        {
            altDriver.Stop();
            Thread.Sleep(1000);
        }


        [Test]
        public void TC_01_TestStartPageLoadedCorrectly()
        {
            Assert.True(startPage.IsDisplayed());
        }

        [Test]
        public void TC_02_TestStartButtonLoadMainMenu()
        {
           
            startPage.PressStart();
            Assert.True(mainMenuPage.IsDisplayed());
            //mainMenuPage.ClickToLeaderBoardButton();
        }

        
    }
}
