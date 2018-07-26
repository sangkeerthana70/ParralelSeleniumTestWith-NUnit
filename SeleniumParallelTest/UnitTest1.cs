using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumParallelTest
{
    [TestFixture]
    public class FireFoxTesting : Hooks
    {
        
        [Test]
        public void FirefoxGoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");//search for Selenium
            Driver.FindElement(By.Id("gsr")).Click();
            Driver.FindElement(By.Name("btnK")).Click();//search button
            //assert that the driver's page source has Selenium in it
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true), 
                                             "The text Selenium does not exist");
        }
    }

    [TestFixture]
    public class ChromeTesting : Hooks
    {
        [Test]
        public void ChromeGoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("ExecuteAutomation");//search for Selenium
            Driver.FindElement(By.Id("gsr")).Click();
            Driver.FindElement(By.Name("btnK")).Click();//search button
            //assert that the driver's page source has Execute Automation in it
            Assert.That(Driver.PageSource.Contains("ExecuteAutomation"), Is.EqualTo(true),
                                             "The text ExecuteAutomation does not exist");

        }
    }
}
