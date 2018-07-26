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
    [TestFixture]
    public class Hooks : Base//inherit the base class property
    {
        //constructor to initialize the driver object
        public Hooks()
        {
            Driver = new ChromeDriver();
            //Driver = new FirefoxDriver();
        }
    }
}
