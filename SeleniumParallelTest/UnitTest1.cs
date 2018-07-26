using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumParallelTest
{
    [TestFixture]
    [Parallelizable]
    public class FireFoxTesting : Hooks
    {
        public FireFoxTesting() : base(BrowserType.Firefox)
        {

        }
        
        [Test]
        public void FirefoxGoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");//search for Selenium
            Driver.FindElement(By.Id("gsr")).Click();
            System.Threading.Thread.Sleep(20000);
            Driver.FindElement(By.Name("btnK")).Click();//search button
            //assert that the driver's page source has Selenium in it
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true), 
                                             "The text Selenium does not exist");
        }
    }

    [TestFixture]
    [Parallelizable]
    public class ChromeTesting : Hooks
    {
        public ChromeTesting() : base(BrowserType.chrome)
        {
        }

        [Test]
        public void ChromeGoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("ExecuteAutomation");//search for Selenium
            //can also use keys.enter to make next element visible 
            Driver.FindElement(By.Id("gsr")).Click();
            Driver.FindElement(By.Name("btnK")).Click();//search button
            //assert that the driver's page source has Execute Automation in it
            Assert.That(Driver.PageSource.Contains("ExecuteAutomation"), Is.EqualTo(true),
                                             "The text ExecuteAutomation does not exist");

        }
    }
}
