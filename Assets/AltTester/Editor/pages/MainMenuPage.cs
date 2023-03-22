using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altom.AltDriver;
using NUnit.Framework;

namespace Assets.AltTester.Editor.pages
{
    public class MainMenuPage : BasePage
    {
        public MainMenuPage(AltDriver driver) : base(driver)
        {
        }
        public void LoadScene()
        {
            Driver.LoadScene("Main");
        }

        public AltObject StoreButton { get => Driver.WaitForObject(By.NAME, "StoreButton", timeout: 10); }
        public AltObject LeaderBoardButton { get => Driver.WaitForObject(By.NAME, "OpenLeaderboard", timeout: 10); }
        public AltObject SettingsButton { get => Driver.WaitForObject(By.NAME, "SettingButton", timeout: 10); }
        public AltObject MissionButton { get => Driver.WaitForObject(By.NAME, "MissionButton", timeout: 10); }
        public AltObject RunButton { get => Driver.WaitForObject(By.NAME, "StartButton", timeout: 10); }
        public AltObject CharacterName { get => Driver.WaitForObject(By.NAME, "CharName", timeout: 10); }
        public AltObject ThemeName { get => Driver.WaitForObject(By.NAME, "ThemeZone", timeout: 10); }
        public bool IsDisplayed()
        {
            if (StoreButton != null && LeaderBoardButton != null && SettingsButton != null && MissionButton != null && RunButton != null && CharacterName != null && ThemeName != null)
                return true;
            return false;
        }
        public void ClickToStoreButton()
        {
            StoreButton.Tap();
            var text = StoreButton.GetText();
            Assert.AreEqual("STORE", text);
        }

        public void ClickToLeaderBoardButton()
        {
            LeaderBoardButton.Tap();
            var text = LeaderBoardButton.GetText();
            Assert.AreEqual("LEADERBOARD", text);
        }

        public void ClickToSettingsButton()
        {
            SettingsButton.Tap();
            var text = SettingsButton.GetText();
            Assert.AreEqual("Settings", text);
        }

        public void ClickToMissionButton()
        {
            MissionButton.Tap();
            var text = MissionButton.GetText();
            Assert.AreEqual("MISSIONS", text);
        }

        public void ClickToRunButton()  
        {
            RunButton.Tap();
        }
    }
}
