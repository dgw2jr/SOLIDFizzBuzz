using TechTalk.SpecFlow;
using TestStack.White;
using System;
using System.IO;
using TestStack.White.UIItems;
using NUnit.Framework;

namespace SOLIDFizzBuzz.Specs
{
    [Binding]
    public class FizzBuzzSteps
    {
        private static Application form;
        private static string exePath = @"..\..\..\WindowsFormsUI\bin\Debug\";
        private static string exeFile = "WindowsFormsUI.exe";
       
        [BeforeFeature]
        public static void SetUp()
        {
            var info = new System.Diagnostics.ProcessStartInfo();
            var path = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + exePath);
            info.FileName = Path.Combine(path, exeFile);

            form = Application.AttachOrLaunch(info);
        }

        [AfterFeature]
        public static void TearDown()
        {
            form.Kill();
        }

        [Given(@"I have entered (.*) into the numeric up down control")]
        public void GivenIHaveEnteredIntoTheNumericUpDownControl(int input)
        {
            var window = form.GetWindow("FizzBuzz");
            window.WaitWhileBusy();

            var numericControl = window.Get<Spinner>("DividendNumericUpDown");
            numericControl.Value = input;
            window.WaitWhileBusy();

            numericControl.KeyIn(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.RETURN);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeFizzOnTheScreen(string message)
        {
            var window = form.GetWindow("FizzBuzz");
            window.WaitWhileBusy();

            var outputLabel = window.Get<Label>("MessageLabel");

            Assert.AreEqual(message, outputLabel.Text);
        }
    }
}
