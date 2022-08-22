using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Edge;
using System.Diagnostics;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace PageClassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeDriver driver=new ChromeDriver();
            driver.Navigate().GoToUrl("https://webdriveruniversity.com/");
            driver.Manage().Window.Maximize();
            PageClassLib.HomePage page = new PageClassLib.HomePage(driver);
            page.HomePage();

            driver= _LinkText.Click();
        }
    }
}
