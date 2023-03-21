using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altom.AltDriver;

namespace Assets.AltTester.Editor.pages
{
    public class PauseOverlayPage : BasePage
    {
        public PauseOverlayPage(AltDriver driver) : base(driver)
        {
        }

        public AltObject ResumeButton { get => Driver.WaitForObject(By.NAME, "Resume", timeout: 5); }
        public AltObject MainMenuButton { get => Driver.WaitForObject(By.NAME, "Exit", timeout: 5); }
        public AltObject Title { get => Driver.WaitForObject(By.NAME, "Text", timeout: 2); }

        public bool IsDisplayed()
        {
            if (ResumeButton != null && MainMenuButton != null && Title != null)
                return true;
            return false;
        }
        public void PressResume()
        {
            ResumeButton.Tap();
        }
        public void PressMainMenu()
        {
            MainMenuButton.Tap();
        }
    }
}
