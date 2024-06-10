using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1

    {
        IWebDriver driver;
        [TestMethod]
        public void TestMethod1()

        {
            var options = new ChromeOptions();
            options.AddExcludedArgument("enable-logging");
            driver = new ChromeDriver(@"C:\Users\user\Desktop\chromedriver-win64", options);
            driver.Url = "https://www.ebay.com/";


            IWebElement element = driver.FindElement(By.Id("gh-ac"));
            Assert.IsNotNull(element);

        }

        [TestMethod]
        public void testMethod2()
        {
            var options = new ChromeOptions();
            options.AddExcludedArgument("enable-logging");
            driver = new ChromeDriver(@"C:\Users\user\Desktop\chromedriver-win64", options);
            driver.Url = "https://www.ebay.com/";

            IWebElement element2 = driver.FindElement(By.Id("gh-btn"));
            Assert.IsNotNull(element2);
        }
    }
}
