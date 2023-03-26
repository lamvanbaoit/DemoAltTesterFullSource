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
    public class FlowLeaderboardPageTests
    {
        AltDriver altDriver;
        MainMenuPage mainMenuPage;
        StartPage startPage;
        FlowLeaderboardPage flowLeaderboardPage;

        [SetUp]
        public void Setup()
        {
            altDriver = new AltDriver();
            //mainMenuPage.LoadScene();
            mainMenuPage = new MainMenuPage(altDriver);
            mainMenuPage.LoadScene();   
            flowLeaderboardPage = new FlowLeaderboardPage(altDriver);
        }

        [TearDown]
        public void Dispose()
        {
            altDriver.Stop();
            Thread.Sleep(1000);
        }


        [Test]
        public void TC_01_TestFlowLeaderBoard()
        {
            mainMenuPage.ClickToLeaderBoardButton();
            flowLeaderboardPage.GetTextNameAndScrore();
            flowLeaderboardPage.ClickToIconClose();
        }


        
    }
}
