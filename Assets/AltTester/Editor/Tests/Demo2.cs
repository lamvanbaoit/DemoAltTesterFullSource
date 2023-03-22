using NUnit.Framework;
using Altom.AltDriver;
using NLog;
using UnityEngine;
using NUnit.Framework.Internal;

public class Demo2
{   //Important! If your test file is inside a folder that contains an .asmdef file, please make sure that the assembly definition references NUnit.
    public AltDriver altDriver;
    private static readonly NLog.Logger logger = LogManager.GetCurrentClassLogger();
    //Before any test it connects with the socket
    [OneTimeSetUp]
    public void SetUp()
    {
        altDriver =new AltDriver();
    }

    //At the end of the test closes the connection with the socket
    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

    [SetUp]
    public void LoadLevel()
    {
        altDriver.ResetInput();
        // Sets the value for the command response timeout.
        altDriver.SetCommandResponseTimeout(60);
        logger.Debug("load level");
    }


    //[Test]
    public void Test()
    {
        //var xbutton = altDriver.FindObject(By.PATH, "//UICamera/Loadout/StartButton/Text");
        //altDriver.HoldButton(xbutton.GetScreenPosition(), 1);

        var startButton = altDriver.FindObject(By.PATH, "//UICamera/Loadout/StartButton/Text");
        var text = startButton.GetText();
        UnityEngine.Debug.Log("++++++++++++++++++++++++++++++++++++++++++lam van bao: " + text);
        Assert.AreEqual(text, "Run!");
        Assert.IsNotNull(startButton);
        startButton.Click();
        logger.Debug("click");
    }

    [Test]
    public void TestScroll()
    {
        altDriver.FindObject(By.PATH, "/UICamera/Loadout/MissionButton").Click();
        var player2 = altDriver.FindObject(By.PATH, "/UICamera/Loadout/MissionPopup/MissionBackground/MissionsContainer/Scroll View/Viewport/Content/MissionEntry(Clone)");
        AltVector3 cubeInitialPosition = new AltVector3(player2.worldX, player2.worldY, player2.worldY);
        altDriver.Scroll(1, 2);

      
    }

}