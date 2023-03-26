using Altom.AltDriver;
using Assets.AltTester.Editor.src.main.pageObjects;
using Assets.AltTester.Editor.src.main.commons;
using NUnit.Framework;
using System;
using Assets.AltTester.Editor.pages;

namespace Assets.AltTester.Editor.src.test.testcase
{
    public class Rival_000_MainMenu : BaseTest
    {
        AltDriver driver;
        MainMenuPageObject mainMenuPage;

        [SetUp]
        public void Setup()
        {
            driver = new AltDriver();
            mainMenuPage = new MainMenuPageObject(driver);
        }

        [TearDown]
        public void Dispose()
        {
            driver.Stop();
            sleepInSecond(3);
        }

        [Test]
        public void TC_01_TestMainMenuPageLoadedCorrectly()
        {
            mainMenuPage.getTextStore();
            mainMenuPage.getTextSetting();
            mainMenuPage.getTextMission();
            mainMenuPage.getTextLeaderBoard();
            Assert.True(mainMenuPage.isDisplayedMainMenus());
        }
    }
}
