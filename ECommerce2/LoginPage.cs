using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;

namespace ECommerce2
{
    internal class LoginPage : UnitTest1
    {
        public bool Login(IWebDriver NewDriver, string Username, string Password)
        {
            NewDriver.FindElement(By.XPath("/text('username')")).SendKeys(Username);
            NewDriver.FindElement(By.XPath("/text('password')")).SendKeys(Password);
            NewDriver.FindElement(By.XPath("/button('submit')")).Click();

            if (NewDriver.FindElement(By.XPath("/label('PageHeading')")).Text == "Login Page")
                return false;
            else if(NewDriver.FindElement(By.XPath("/label('PageHeading')")).Text == "Product Page")
                return true; 
        }
    }
}
