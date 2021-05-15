using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium_C
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.hygiena.com/food-and-beverage-products/food-and-beverage-processing.html";

            IWebElement lanuageFieldDriver.FindElement(By.XPath(".//*[@id = '0.targetLanguage']"));
            lanuageFieldDriver.SendKeys("Albanian");
            driver.Quit();
        }
    }
}