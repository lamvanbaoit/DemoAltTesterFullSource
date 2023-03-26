using Altom.AltDriver;
using Assets.AltTester.Editor.src.main.commons;
using Assets.AltTester.Editor.src.main.pageUIs;
using NUnit.Framework;

namespace Assets.AltTester.Editor.src.main.pageObjects
{
    public class MainMenuPageObject : BasePage
    {
        AltDriver driver;

        public MainMenuPageObject(AltDriver driver)
        {
            this.driver = driver;
        }

        public bool isDisplayedMainMenus()
        {
            if (MainMenuUI.STORE_BUTTON != null && MainMenuUI.LEADER_BOARD != null && MainMenuUI.SETTING_BUTTON != null && MainMenuUI.MISSION_BUTTON != null && MainMenuUI.RUN_BUTTON != null)
            {
                return true;
            }
            return false;
        }

        public void getTextStore()
        {
            var text = geElementText(driver, MainMenuUI.TEXT_STORE_BUTTON);
            Assert.AreEqual("STORE", text);
        }

        public void getTextLeaderBoard()
        {
            var text = geElementText(driver, MainMenuUI.TEXT_LEADER_BOARD);
            Assert.AreEqual("LEADERBOARD", text);
        }

        public void getTextSetting()
        {
            var text = geElementText(driver, MainMenuUI.TEXT_SETTING_BUTTON);
            Assert.AreEqual("Settings", text);
        }

        public void getTextMission()
        {
            var text = geElementText(driver, MainMenuUI.TEXT_MISSION_BUTTON);
            Assert.AreEqual("MISSIONS", text);
        }

        public void tapToStoreButton()
        {
            tapToElement(driver, MainMenuUI.STORE_BUTTON);
        }


    }
}