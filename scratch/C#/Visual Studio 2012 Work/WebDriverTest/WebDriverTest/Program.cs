using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriverTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://www.google.com");

            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("CAA");
            element.Submit();

            try
            {
            IWebElement results = driver.FindElement(By.CssSelector("h3.r"));

            Console.WriteLine("Page title is " + results.Text);
            Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                driver.Close();
            }
        }
    }
}
