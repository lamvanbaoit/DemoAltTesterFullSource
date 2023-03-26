using System.Threading;
using Altom.AltDriver;

namespace Assets.AltTester.Editor.src.main.commons
{
    public class BasePage
    {
        double timeout = 30;

        public void waitElement(AltDriver driver, string locator)
        {
            driver.WaitForObject(By.PATH, locator, timeout: timeout);
        }

        public AltObject getElement(AltDriver driver, string locator)
        {
            return driver.FindObject(By.PATH, locator);
        }

        public void clickToElement(AltDriver driver, string locator)
        {
            getElement(driver, locator).Click();
        }

        public void tapToElement(AltDriver driver, string locator)
        {
            getElement(driver, locator).Tap();
        }

        public string geElementText(AltDriver driver, string locator)
        {
            return getElement(driver, locator).GetText();
        }

        public void scroll(AltDriver driver, float x1, float y1)
        {
            driver.Scroll(new AltVector2(x1, y1));
        }

        public void swipe(AltDriver driver, float x1, float y1, float x2, float y2)
        {
            driver.Swipe(new AltVector2(x1, y1), new AltVector2(x2, y2));
        }

        public void screenShot(AltDriver driver, string path)
        {
            driver.GetPNGScreenshot(path);
        }
    }
}