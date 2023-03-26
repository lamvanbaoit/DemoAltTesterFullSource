using Altom.AltDriver;
using Assets.AltTester.Editor.src.main.commons;
using Assets.AltTester.Editor.src.main.pageUIs;

namespace Assets.AltTester.Editor.src.main.pageObjects
{
    public class StorePageObject : BasePage
    {
        AltDriver driver;

        public StorePageObject(AltDriver driver)
        {
            this.driver = driver;
        }

        public void tapToCharactersButton()
        {
            waitElement(driver, StorePageUI.BUTTON_CHRACTERS);
            tapToElement(driver, StorePageUI.BUTTON_CHRACTERS);
        }

        public void tapToAccessoriesButton()
        {
            waitElement(driver, StorePageUI.BUTTON_ACCESSORIES);
            tapToElement(driver, StorePageUI.BUTTON_ACCESSORIES);
        }

        public void tapToThemesButton()
        {
            waitElement(driver, StorePageUI.BUTTON_THEMES);
            tapToElement(driver, StorePageUI.BUTTON_THEMES);
        }

        public void tapToCloseIcon()
        {
            waitElement(driver, StorePageUI.ICON_CLOSE);
            tapToElement(driver, StorePageUI.ICON_CLOSE);
        }

        public void chractersScreenShot()
        {
            screenShot(driver, "Assets\\AltTester\\Editor\\src\\main\\commons\\images\\Stores\\CHRACTERS.png");
        }

        public void accessoriesScreenShot()
        {
            screenShot(driver, "Assets\\AltTester\\Editor\\src\\main\\commons\\images\\Stores\\ACCESSORIES.png");
        }

        public void themesScreenShot()
        {
            screenShot(driver, "Assets\\AltTester\\Editor\\src\\main\\commons\\images\\Stores\\THEMES.png");
        }

        public void scrollStore()
        {
            scroll(driver, 0, 800);
        }

        public void swipeStore()
        {
            swipe(driver, 540, 480, 540, 1280);
        }
    }
}
