using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlaUI.Core;
using System.IO;
using FlaUI.UIA3;
using FlaUI.Core.Conditions;
using FlaUI.Core.AutomationElements;

namespace AutoTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            // for tests, you need to put your computer's file path for debug exe for the application.launch method
            var application = Application.Launch(@"C:\Users\jedik\source\repos\Tidogo\SafePass\SignUp\bin\Debug\Main_Project.exe");
            // this line creates a var local variable of the main window running with the automation framework
            var mainWindow = application.GetMainWindow(new UIA3Automation());
            // this line instantiates the library of properties and conditions to manipulate the main window
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            // these three lines fill the login info with a known account and tries to log in
            // if it works, it will give you a green check mark when you run the test
            // byautomationid grabs elements by design name
            // byname grabs elements by the display text (i.e. "LOG IN" is the display text for the login button)
            mainWindow.FindFirstDescendant(cf.ByAutomationId("txtUsername")).AsTextBox().Enter("safepass@gmail.com");
            mainWindow.FindFirstDescendant(cf.ByAutomationId("txtPassword")).AsTextBox().Enter("1234567890");
            mainWindow.FindFirstDescendant(cf.ByName("LOG IN")).AsButton().Click();
        }
    }
}