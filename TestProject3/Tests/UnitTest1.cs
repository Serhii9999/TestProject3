using NUnit.Framework;
using OpenQA.Selenium;
using TestProject3.PageObject;

namespace TestProject3
{
    public class Tests
    {

        IWebDriver driver;
        
        [SetUp]
        public void Setup()
            
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://google.com");

        }

        [Test]
        public void Test1()
        {
            var pic = new SearchPage(driver);
            pic.clickPicture();
       
        }

        public void tearDown()
        {
            driver.Quit();
        }
    }
}