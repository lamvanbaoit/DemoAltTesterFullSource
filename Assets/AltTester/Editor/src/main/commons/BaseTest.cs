using System.Threading;
using Altom.AltDriver;

namespace Assets.AltTester.Editor.src.main.commons
{
    public class BaseTest
    {
        private AltDriver driver;

        public void sleepInSecond(int timeInSecond)
        {
            Thread.Sleep(timeInSecond * 1000);
        }
    }
}