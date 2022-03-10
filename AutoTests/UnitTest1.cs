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
            var enviroment = System.Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(enviroment).Parent.FullName;
            var application = Application.Launch(@"C:\Users\jedik\source\repos\Tidogo\SafePass\SignUp\bin\Debug\Main_Project.exe");
            var mainWindow = application.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            mainWindow.FindFirstDescendant(cf.ByAutomationId("txtUsername")).AsTextBox().Enter("safepass@gmail.com");
            mainWindow.FindFirstDescendant(cf.ByAutomationId("txtPassword")).AsTextBox().Enter("1234567890");
            mainWindow.FindFirstDescendant(cf.ByName("LOG IN")).AsButton().Click();
        }
    }
}