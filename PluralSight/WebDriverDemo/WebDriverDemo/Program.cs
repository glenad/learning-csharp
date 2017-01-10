using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();  //InternetExplorerDriver(@"C:\Python27");
            driver.Url = @"C:\Projects\PluralSight\WebDriverDemo\WebDriverDemo\TestPage.html";

            //driver.Url = "http://www.google.com";

            //var searchBox = driver.FindElement(By.Id("gs_lc0"));
            //searchBox.SendKeys("pluralsight");
            //searchBox.SendKeys(Keys.Return);

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            //var imagesLink = driver.FindElements(By.ClassName("qs"))[1];
            //imagesLink.Click();

            //var div = driver.FindElement(By.ClassName("rg_bb_layout"));
            //var firstImageLink = div.FindElements(By.TagName("img"))[0];
            //firstImageLink.Click();

            var radioButtons = driver.FindElements(By.Name("color"));
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Selected)
                    Console.WriteLine(radioButton.GetAttribute("value"));
            }
            
            //radioButton.Click();

        }
    }
}
