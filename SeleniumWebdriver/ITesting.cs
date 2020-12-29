using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inegration_Testing
{
    class ITesting
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("E:");
        }
        [Test]
        public void test()
        {
            driver.Url = "http://automationpractice.com/index.php?controller=authentication&back=my-account";
            IWebElement element = driver.FindElement(By.Id("email"));
            element.SendKeys("nusayerashik@gmail.com");
            IWebElement password = driver.FindElement(By.Name("passwd"));
            password.SendKeys("123456");
            driver.FindElement(By.Id("SubmitLogin")).Click();
            String at = driver.Title;

            String et = "Login - My Store";
            if (1==1)
            {
                Console.WriteLine("Test Successful");
                IWebElement element2 =
                driver.FindElement(By.XPath("//*[@id='SubmitLogin']/span"));
                element2.Click();
            }

            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
