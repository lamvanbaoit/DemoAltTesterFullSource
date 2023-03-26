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
    public class FlowLeaderboardPage: BasePage
    {
        public FlowLeaderboardPage(AltDriver driver) : base(driver)
        {
        }

        public AltObject IconClose { get => Driver.WaitForObject(By.PATH, "/UICamera/Leaderboard/Background/Button", timeout: 15); }
        public AltObject TextName { get => Driver.WaitForObject(By.PATH, "/UICamera/Leaderboard/Background/Display/Score/Name", timeout: 15); }
        public AltObject TextScore { get => Driver.WaitForObject(By.PATH, "/UICamera/Leaderboard/Background/Display/Score/Score", timeout: 15); }
        
        
        public void GetTextNameAndScrore()
        {
            var textName = TextName.GetText();
            Assert.AreEqual("Trash Cat", textName);
            var textScore = TextScore.GetText();
            Assert.NotNull(textScore.Length);
        }

        public void ClickToIconClose()
        {
            IconClose.Tap();
        }
        
    }
}
