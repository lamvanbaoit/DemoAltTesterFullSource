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

        public AltObject StoreButton { get => Driver.WaitForObject(By.PATH, "/UICamera/Loadout/StoreButton/Text", timeout: 10); }
        public AltObject LeaderBoardButton { get => Driver.WaitForObject(By.PATH, "/UICamera/Loadout/OpenLeaderboard/Text", timeout: 10); }
        public AltObject SettingsButton { get => Driver.WaitForObject(By.PATH, "/UICamera/Loadout/SettingButton/Text", timeout: 10); }
        public AltObject MissionButton { get => Driver.WaitForObject(By.PATH, "/UICamera/Loadout/MissionButton/Text", timeout: 10); }
        public AltObject RunButton { get => Driver.WaitForObject(By.NAME, "/UICamera/Loadout/StartButton", timeout: 10); }
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
            var text = StoreButton.GetText();
            Assert.AreEqual("STORE", text);
            StoreButton.Click();
        }

        public void ClickToLeaderBoardButton()
        {
            var text = LeaderBoardButton.GetText();
            Assert.AreEqual("LEADERBOARD", text);
            LeaderBoardButton.Click();
        }

        public void ClickToSettingsButton()
        {
            var text = SettingsButton.GetText();
            Assert.AreEqual("Settings", text);
            SettingsButton.Tap();
        }

        public void ClickToMissionButton()
        {
            var text = MissionButton.GetText();
            Assert.AreEqual("MISSIONS", text);
            MissionButton.Tap();
        }

        public void ClickToRunButton()  
        {
            RunButton.Tap();
        }
    }
}
