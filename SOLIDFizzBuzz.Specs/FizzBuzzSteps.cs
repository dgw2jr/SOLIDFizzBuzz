using TechTalk.SpecFlow;
using TestStack.White;
using System;
using System.IO;
using TestStack.White.UIItems;
using NUnit.Framework;
using TestStack.White.UIItems.WindowItems;

namespace SOLIDFizzBuzz.Specs
{
    [Binding]
    public class FizzBuzzSteps
    {
        private static Application form;
        private static string exePath = @"..\..\..\WindowsFormsUI\bin\Debug\";
        private static string exeFile = "WindowsFormsUI.exe";
        private static string windowTitle = "FizzBuzz";

        private static Window window;
       
        [BeforeFeature]
        public static void SetUp()
        {
            var info = new System.Diagnostics.ProcessStartInfo();
            var path = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + exePath);
            info.FileName = Path.Combine(path, exeFile);

            form = Application.AttachOrLaunch(info);
            window = form.GetWindow(windowTitle);
        }

        [AfterFeature]
        public static void TearDown()
        {
            form.Kill();
        }

        [Given(@"I have entered (.*) into the (.*) control")]
        public void GivenIHaveEnteredIntoControl(int input, string wellKnownControlName)
        {
            window.WaitWhileBusy();

            var numericControl = window.Get<Spinner>(wellKnownControlName);
            numericControl.Value = input;
            window.WaitWhileBusy();

            numericControl.KeyIn(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.RETURN);
        }
        
        [Then(@"the result should be (.*) in the (.*) control")]
        public void ThenTheResultShouldBeFizzOnTheScreen(string message, string wellKnownControlName)
        {
            var window = form.GetWindow("FizzBuzz");
            window.WaitWhileBusy();

            var outputLabel = window.Get<Label>(wellKnownControlName);

            Assert.AreEqual(message, outputLabel.Text);
        }
    }
}
