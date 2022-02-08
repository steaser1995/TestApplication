using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;

namespace ECommerce2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver NewDriver = new ChromeDriver();
            String Username, Password;
            bool flag;

            // Going to pick up username and password from data sheet

            string url = "https://www.amazon.in";
            NewDriver.Navigate().GoToUrl(url);

            NewDriver.FindElement(By.XPath("/a('Login')");

            flag = Login(NewDriver, Username, Password);
            Assert.IsTrue(flag);


        }
    }
}
