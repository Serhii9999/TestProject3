using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject3.PageObject;

namespace TestProject3
{
    public class Tests
    {

        IWebDriver driver;
        
        [SetUp]
        public void Setup()
            
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("Headless");
            driver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl("https://facebook.com");

        }

        [Test]
        public void Test1()
        {
            
            var pic = new SearchPage(driver);
            pic.clickForgotPassword();
            var expectedURL = "https://www.facebook.com/login/identify/?ctx=recover&ars=facebook_login&from_login_screen=0";
            Assert.AreEqual(expectedURL, driver.Url);
        }

        public void tearDown()
        {
            driver.Quit();
        }
    }
}