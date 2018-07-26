using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumParallelTest
{

    public enum BrowserType
    {
        chrome,
        Firefox,
        IE
    }
    [TestFixture]
    public class Hooks : Base//inherit the base class property
    {
        private BrowserType _browserType;

        //constructor to initialize the driver object
        public Hooks(BrowserType browser)
        {
            _browserType = browser;
            
        }

        [SetUp]
        public void InitializeTest()
        {
            ChooseDriverInstance(_browserType);
        }

        private void ChooseDriverInstance (BrowserType browserType)
        {
            if (browserType == BrowserType.chrome)
                Driver = new ChromeDriver();
            if (browserType == BrowserType.Firefox)
                Driver = new FirefoxDriver();
        }
    }
}
