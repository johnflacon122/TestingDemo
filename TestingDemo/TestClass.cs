// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestingDemo
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.news.com.au/";

            //driver.FindElement(By.Id("show-search")).Click();
            driver.FindElement(By.Id("search-input")).Click();

            driver.FindElement(By.Id("search-input")).SendKeys("coronavirus");

            driver.FindElement(By.Id("show-search")).Click();

            Thread.Sleep(2000);

            IList<IWebElement> list = driver.FindElements(By.XPath("//div[@class='group search-results']//div//a//h5"));

            System.Console.WriteLine(list.Count);

            foreach(IWebElement el in list)
            {
                System.Console.WriteLine(el.Text);
            }

            driver.Quit();
        }

        
        [Test]
        public void TestMethod2()
        {
            System.Console.WriteLine("TestMethod2");
        }

        [Test]
        public void TestMethod3()
        {
            System.Console.WriteLine("TestMethod2");
        }

        [Test]
        public void TestMethod4()
        {
            System.Console.WriteLine("TestMethod23748433");
            System.Console.WriteLine("xxxxxx");
        }
    }
}
