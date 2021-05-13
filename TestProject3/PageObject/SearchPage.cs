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

        private readonly By picture = By.XPath("//img[@id='hplogo']");

        public  void clickPicture()
        {
            driver.FindElement(picture).Click();
        }
    }
}
