using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample99
{
    class demo99
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\seleniumcsharp");
        }

        [Test]
        public void test()
        {
            driver.Url = "http://www.google.co.in";
            string pagetitle = driver.Title;
            Console.WriteLine("sasanks", pagetitle);
        }

        [Test]
        public void test1()
        {
            driver.Url = "http://www.gmail.com";
        }
        [Test]
        public void cssDemo()
        {
            driver.Url = "http://demo.guru99.com/test/guru99home/";
            driver.Manage().Window.Maximize();
            IWebElement link = driver.FindElement(By.XPath(".//*[@id='rt-header']//div[2]/div/ul/li[2]/a"));
            link.Click();
            driver.Close();
        }

        [Test]
        public void cssDem1o()
        {
           // driver = new ChromeDriver("G:\\");
            driver.Url = "http://demo.guru99.com/test/guru99home/";
            driver.Manage().Window.Maximize();
            // Store locator values of email text box and sign up button				
            IWebElement emailTextBox = driver.FindElement(By.XPath(".//*[@id='philadelphia-field-email']"));
            IWebElement signUpButton = driver.FindElement(By.XPath(".//*[@id='philadelphia-field-submit']"));
            emailTextBox.SendKeys("test123@gmail.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            signUpButton.Click();
            driver.SwitchTo().Alert().Accept();
        }
     /*   [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }*/

    }
}