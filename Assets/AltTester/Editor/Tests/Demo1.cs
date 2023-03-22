 using NUnit.Framework;
using Altom.AltDriver;
using System.Diagnostics;
using UnityEngine;
using NLog;
using System;
using System.Threading;

public class Demo1
{   //Important! If your test file is inside a folder that contains an .asmdef file, please make sure that the assembly definition references NUnit.
    public AltDriver altDriver;
    private static readonly NLog.Logger logger = LogManager.GetCurrentClassLogger();
    //Before any test it connects with the socket
    [OneTimeSetUp]
    public void SetUp()
    {
        altDriver = new AltDriver();
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
    public void isPath()
    {
        var a = altDriver.FindObject(By.PATH, "/UICamera/Loadout/StartButton");
        Assert.NotNull(a);
        logger.Debug("{0}", a);
        UnityEngine.Debug.Log("lam van bao" + a);

        var isRoot = altDriver.FindObject(By.PATH, "/UICamera/Loadout/..");
        Assert.NotNull(isRoot);

        var isTag = altDriver.FindObject(By.PATH, "/UICamera/Loadout/StartButton/*[@tag=Untagged]");
        Assert.NotNull(isTag);

        var iLayer = altDriver.FindObject(By.PATH, "/UICamera/Loadout/StartButton/*[@layer=UI]");
        Assert.NotNull(iLayer);

        var isText = altDriver.FindObject(By.PATH, "/UICamera/Loadout/StartButton/*[@text=Run!]");
        Assert.NotNull(isText);

        var isContains = altDriver.FindObject(By.PATH, "/UICamera/Loadout/StartButton/*[contains(@text,Run!)]");
        Assert.NotNull(isContains);

        var isMultiple = altDriver.FindObject(By.PATH, "/UICamera/Loadout/StartButton/*[@tag=Untagged][@layer=UI][@text=Run!]");
        Assert.NotNull(isMultiple);

        // chưa tìm được
        var isFindObject = altDriver.FindObject(By.PATH, "/UICamera/Loadout/StartButton[@component=Button]");
        Assert.NotNull(isFindObject);
    }

    [Test]
    public void Test()  
    {
        var startButton = altDriver.FindObject(By.PATH, "//UICamera/Loadout/StartButton");
        Assert.IsNotNull(startButton);
        startButton.Click();
        logger.Debug("click");

        //AltKeyCode kcode = AltKeyCode.A;
        //altDriver.KeyUp(kcode);
        //altDriver.KeyDown(kcode, 1);
    }



    //[Test]
    public void testfindaltobject()
    {
        const string isTextLeaderBoard = "OpenLeaderboard";
        var altobject = altDriver.FindObject(By.PATH, string.Format("/UICamera/Loadout/{0}", isTextLeaderBoard)).Click();

        altDriver.WaitForObject(By.NAME, "PlayerPivot");
        altDriver.PressKey(AltKeyCode.DownArrow);
        Assert.NotNull(altobject);
        Assert.AreEqual(isTextLeaderBoard, altobject.name);

        var altObject2 = altDriver.FindObjects(By.PATH, "/UICamera/Leaderboard/Background/Display//*//Name");
        foreach (var index in altObject2)
        {
            UnityEngine.Debug.Log("lam van bao: " + altObject2 + " : " + index.GetText());
            Assert.AreEqual("Trash Cat", index.GetText());
        }

        var timeStart = DateTime.Now;
        altDriver.WaitForObject(By.PATH, "/UICamera/Leaderboard/Background/Display//*//Score");
        var timeEnd = DateTime.Now;
        var time = timeEnd - timeStart;
        UnityEngine.Debug.Log("*************************************************************: " + time);
        Assert.Less(time.TotalSeconds, 20);
        
        var altObject3 = altDriver.FindObjects(By.PATH, "/UICamera/Leaderboard/Background/Display//*//Score");
        foreach (var index in altObject3)
        {
            UnityEngine.Debug.Log("*************************************************************lam van bao: " + index.ToString() + " : " + index.GetText());
            //Assert.AreEqual("746", index.GetText());
        }
    }

    //[Test]
    //public void TestFindObjectsByTag()
    //{
    //    var altObjects = altDriver.FindObjects(By.TAG, "plane");
    //    Assert.AreEqual(2, altObjects.Count);
    //    foreach (var altObject in altObjects)
    //    {
    //        Assert.AreEqual("Plane", altObject.name);
    //    }
    //}

    //[Test]
    //public void TestFindObjectWhichContains()
    //{
    //    var altObject = altDriver.FindObjectWhichContains(By.NAME, "Event");
    //    Assert.AreEqual("EventSystem", altObject.name);
    //}

    //[Test]
    //public void TestFindObjects()
    //{
    //    var planes = altDriver.FindObjectsWhichContain(By.NAME, "Plane");
    //    Assert.AreEqual(3, planes.Count);
    //}

    //[Test]
    //public void TestFindElementAtCoordinates()
    //{
    //    var counterButton = altDriver.FindObject(By.NAME, "ButtonCounter");
    //    var element = altDriver.FindObjectAtCoordinates(new AltVector2(80 + counterButton.x, 15 + counterButton.y));
    //    Assert.AreEqual("Text", element.name);
    //}

    //[Test]
    //public void TestGetAllEnabledObjects()
    //{
    //    var altObjects = altDriver.GetAllElements(enabled: true);
    //    Assert.IsNotEmpty(altObjects);
    //}

    //[Test]
    //public void TestWaitForExistingElement()
    //{
    //    const string name = "Capsule";
    //    var timeStart = DateTime.Now;
    //    var altElement = altDriver.WaitForObject(By.NAME, name);
    //    var timeEnd = DateTime.Now;
    //    var time = timeEnd - timeStart;
    //    Assert.Less(time.TotalSeconds, 20);
    //    Assert.NotNull(altElement);
    //    Assert.AreEqual(altElement.name, name);
    //}

    //[Test]
    //public void TestWaitForObjectWhichContains()
    //{
    //    var altObject = altDriver.WaitForObjectWhichContains(By.NAME, "Canva");
    //    Assert.AreEqual("Canvas", altObject.name);
    //}

    //[Test]
    //public void TestWaitForObjectToNotExist()
    //{
    //    altDriver.WaitForObjectNotBePresent(By.NAME, "Capsulee", timeout: 1, interval: 0.5f);
    //}


}