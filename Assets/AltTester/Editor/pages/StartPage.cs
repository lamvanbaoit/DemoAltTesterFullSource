using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altom.AltDriver;
using NUnit.Framework;
using UnityEngine;

namespace Assets.AltTester.Editor.pages
{
    public class StartPage : BasePage
    {
        public StartPage(AltDriver driver) : base(driver)
        {
        }

        public void Load()
        {
            Driver.LoadScene("Start");
        }

        public AltObject StartButton { get => Driver.WaitForObject(By.NAME, "StartButton", timeout: 15); }

        public bool IsDisplayed()
        {
            if (StartButton != null)
                return true;
            return false;
        }
        public void PressStart()
        {
            StartButton.Tap();
        }
        public void GetStartButtonText()
        {
            var text = StartButton.GetText();
            Assert.AreEqual("Run!", text);
        }
    }
}
