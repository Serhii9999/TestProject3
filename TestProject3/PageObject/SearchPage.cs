using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject3.PageObject
{
    class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private readonly By forgotPassword = By.XPath("//div[@class='_6ltj']/a");

        public  void clickForgotPassword()
        {
            driver.FindElement(forgotPassword).Click();
        }
    }
}
