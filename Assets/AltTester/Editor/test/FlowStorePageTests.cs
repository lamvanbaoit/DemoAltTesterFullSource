using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Altom.AltDriver;
using Assets.AltTester.Editor.pages;
using NUnit.Framework;

namespace Assets.AltTester.Editor.test
{
    public class FlowStorePageTests
    {

        AltDriver altDriver;
        MainMenuPage mainMenuPage;
        FlowStorePage flowStorePage;

        [SetUp]
        public void Setup()
        {
            altDriver = new AltDriver();
            mainMenuPage = new MainMenuPage(altDriver);
            mainMenuPage.LoadScene();
            flowStorePage = new FlowStorePage(altDriver);
        }

        [TearDown]
        public void Dispose()
        {
            altDriver.Stop();
            Thread.Sleep(1000);
        }


        [Test]
        public void TC_01_Teststore()
        {
            mainMenuPage.ClickToStoreButton();
            flowStorePage.ScrollBottom();
        }


    }


}
