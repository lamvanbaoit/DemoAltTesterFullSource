using Altom.AltDriver;
using Assets.AltTester.Editor.src.main.commons;
using Assets.AltTester.Editor.src.main.pageObjects;
using NUnit.Framework;

namespace Assets.AltTester.Editor.src.test.testcase
{
    public class Rival_001_Strore : BaseTest
    {
        AltDriver driver;
        StorePageObject storePage;
        MainMenuPageObject mainMenuPage;

        [SetUp]
        public void Setup()
        {
            driver = new AltDriver();
            storePage = new StorePageObject(driver);
            mainMenuPage = new MainMenuPageObject(driver);
        }

        [TearDown]
        public void Dispose()
        {
            driver.Stop();
            sleepInSecond(3);
        }

        [Test]
        public void Rival_Login_TC_001_StoreSuccess()
        {
            mainMenuPage.tapToStoreButton();
            storePage.tapToCharactersButton();
            storePage.chractersScreenShot();
            storePage.scrollStore();
        }

        [Test]
        public void Rival_Login_TC_002_AccessoriesSuccess()
        {
            storePage.tapToAccessoriesButton();
            storePage.accessoriesScreenShot();
            storePage.swipeStore();
        }

        [Test]
        public void Rival_Login_TC_003_ThemesSuccess()
        {
            storePage.tapToThemesButton();
            storePage.themesScreenShot();
            storePage.tapToCloseIcon();
        }
    }
}