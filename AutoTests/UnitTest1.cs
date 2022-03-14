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
        public void AccTest1()
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

        [TestMethod]
        public void AccTest2()
        {
            var application = Application.Launch(@"C:\Users\jedik\source\repos\Tidogo\SafePass\SignUp\bin\Debug\Main_Project.exe");
            var mainWindow = application.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            mainWindow.FindFirstDescendant(cf.ByAutomationId("pressCreateAcc")).AsLabel().Click();
        }

        [TestMethod]
        public void AccTest3()
        {
            var application = Application.Launch(@"C:\Users\jedik\source\repos\Tidogo\SafePass\SignUp\bin\Debug\Main_Project.exe");
            var mainWindow = application.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            mainWindow.FindFirstDescendant(cf.ByAutomationId("pressCreateAcc")).AsLabel().Click();
            var subWindow = application.GetMainWindow(new UIA3Automation());
            subWindow.FindFirstDescendant(cf.ByAutomationId("txtEmail")).AsTextBox().Enter("][p234c@gmail.com");
            subWindow.FindFirstDescendant(cf.ByAutomationId("txtPassword")).AsTextBox().Enter("][p234c@gmail.com");
            subWindow.FindFirstDescendant(cf.ByAutomationId("txtConfPassword")).AsTextBox().Enter("][p234c@gmail.com");
            subWindow.FindFirstDescendant(cf.ByName("SIGN UP")).AsButton().Click();
        }

        [TestMethod]
        public void AccTest4()
        {
            var application = Application.Launch(@"C:\Users\jedik\source\repos\Tidogo\SafePass\SignUp\bin\Debug\MainMenu-Prototype.exe");
            var mainWindow = application.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            mainWindow.FindFirstDescendant(cf.ByName("Generate Password")).AsButton().Click();
            var subWindow = application.GetMainWindow(new UIA3Automation());
            subWindow.FindFirstDescendant(cf.ByName("Create Password")).AsButton().Click();
            subWindow.FindFirstDescendant(cf.ByName("Copy to Clipboard")).AsButton().Click();
            subWindow.FindFirstDescendant(cf.ByName("Back")).AsButton().Click();
        }

        [TestMethod]
        public void AccTest5()
        {
            var application = Application.Launch(@"C:\Users\jedik\source\repos\Tidogo\SafePass\SignUp\bin\Debug\MainMenu-Prototype.exe");
            var mainWindow = application.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            mainWindow.FindFirstDescendant(cf.ByAutomationId("btnResetMasterPass")).AsButton().Click();
            var subWindow = application.GetMainWindow(new UIA3Automation());
            subWindow.FindFirstDescendant(cf.ByAutomationId("txtNewPass")).AsTextBox().Enter("S4f3p4ss");
            subWindow.FindFirstDescendant(cf.ByAutomationId("txtConfNewPass")).AsTextBox().Enter("S4f3p4ss");
            subWindow.FindFirstDescendant(cf.ByAutomationId("btnChangePass")).AsButton().Click();
            /*var application = Application.Launch(@"C:\Users\jedik\source\repos\Tidogo\SafePass\SignUp\bin\Debug\Main_Project.exe");
            var mainWindow = application.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            mainWindow.FindFirstDescendant(cf.ByAutomationId("txtUsername")).AsTextBox().Enter("safepass@gmail.com");
            mainWindow.FindFirstDescendant(cf.ByAutomationId("txtPassword")).AsTextBox().Enter("1234567890");
            mainWindow.FindFirstDescendant(cf.ByName("LOG IN")).AsButton().Click();
            var subWindow = application.GetMainWindow(new UIA3Automation());
            subWindow.FindFirstDescendant(cf.ByAutomationId("txtCode")).AsTextBox().Enter(subWindow.FindFirstDescendant(cf.ByAutomationId("txtDevAuth")).Name);
            subWindow.FindFirstDescendant(cf.ByAutomationId("btnEnter")).AsButton().Click();
            var subSubWindow = application.GetMainWindow(new UIA3Automation());
            subSubWindow.FindFirstDescendant(cf.ByAutomationId("btnResetMasterPass")).AsButton().Click();
            subSubWindow.FindFirstDescendant(cf.ByAutomationId("txtNewPass")).AsTextBox().Enter("S4f3p4ss");
            subSubWindow.FindFirstDescendant(cf.ByAutomationId("txtConfNewPass")).AsTextBox().Enter("S4f3p4ss");
            subSubWindow.FindFirstDescendant(cf.ByAutomationId("btnChangePass")).AsButton().Click();
            subSubWindow.FindFirstDescendant(cf.ByAutomationId("btnBack")).AsButton().Click();*/
        }

        [TestMethod]
        public void AccTest6()
        {
            var application = Application.Launch(@"C:\Users\jedik\source\repos\Tidogo\SafePass\SignUp\bin\Debug\Main_Project.exe");
            var mainWindow = application.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            mainWindow.FindFirstDescendant(cf.ByAutomationId("txtUsername")).AsTextBox().Enter("safepass@gmail.com");
            mainWindow.FindFirstDescendant(cf.ByAutomationId("txtPassword")).AsTextBox().Enter("1234567890");
            mainWindow.FindFirstDescendant(cf.ByName("LOG IN")).AsButton().Click();
            var subWindow = application.GetMainWindow(new UIA3Automation());
            string code = subWindow.FindFirstDescendant(cf.ByAutomationId("txtDevAuth")).AsTextBox().ToString();
        }

        [TestMethod]
        public void AccTest7()
        {
            var application = Application.Launch(@"C:\Users\jedik\source\repos\Tidogo\SafePass\SignUp\bin\Debug\MainMenu-Prototype.exe");
            var mainWindow = application.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            mainWindow.FindFirstDescendant(cf.ByAutomationId("btnHelp")).AsButton().Click();
            var subWindow = application.GetMainWindow(new UIA3Automation());
            subWindow.FindFirstDescendant(cf.ByAutomationId("btn_OpenEmail")).AsButton().Click();
        }


    }
}