using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using AjayScript.Base;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.DevTools.V123.DOM;

namespace AjayScript
{
    [TestClass]
    public class AutoComplete : BaseClass
    {
       
        [TestMethod]
        public void AutocompleteSuggestions()
        {
            // 1.Autocomplete Suggestions
            System.Console.WriteLine("Autocomplete Suggestions Started");
            Thread.Sleep(2000);
            //Driver title is printed in output
            Console.WriteLine(driver.Title);            
            // Assert.IsTrue(driver.Title.Contains("Online Shopping site in India: Shop Online for Mobiles, Books, Watches, Shoes and More - Amazon.in"));
            Thread.Sleep(2000);
            string actualTitle = driver.Title;
            string expectedTitle = "Online Shopping site in India: Shop Online for Mobiles, Books, Watches, Shoes and More - Amazon.in";
            if (actualTitle.Equals(expectedTitle))
            {
                System.Console.WriteLine("Webpage title test passed: Title is as expected.");
            }
            else
            {
                System.Console.WriteLine("Webpage title test failed: Title is not as expected.");
             }
            //Locating the search bar and in it keyword laptop is searched
            Thread.Sleep(2000);
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("laptop");
            System.Console.WriteLine("Locating the Search bar element and keyword laptop is typed");

            driver.FindElement(By.Id("nav-search-submit-button")).SendKeys(Keys.Enter);
            System.Console.WriteLine("In search bar laptop is typed and searched");
            Console.WriteLine(driver.Title);
            Thread.Sleep(2000);
            string actualTitle1 = driver.Title;
            string expectedTitle1 = "Amazon.in : laptop";
            if (actualTitle1.Equals(expectedTitle1))
            {
                System.Console.WriteLine("The Autocomplete Suggestions test passed: Title is as expected.");
            }
            else
            {
                System.Console.WriteLine("The Autocomplete Suggestions test failed: Title is not as expected.");
            }
             driver.FindElement(By.XPath("//*[@id=\"search\"]/div[1]/div[1]/div/span[1]/div[1]/div[6]/div/div/span/div/div/div/div[2]/div/div/div[1]/h2/a/span")).Click();
             Thread.Sleep(6000);
             string ChildWindowName = driver.WindowHandles[1];
             driver.SwitchTo().Window(ChildWindowName);
             Thread.Sleep(2000);
             System.Console.WriteLine(driver.Title);
             string actualTitle2 = driver.Title;
             string expectedTitle2 = "Lenovo IdeaPad Slim 1 AMD Ryzen 5 5500U 15.6\" HD Thin and Light Laptop (16GB/512GB SSD/Windows 11 Home/MS Office 2021/1Yr ADP Free/Cloud Grey/1.61Kg), 82R400ERIN : Amazon.in: Electronics";
             if (actualTitle2.Equals(expectedTitle2))
             {
                 System.Console.WriteLine("The Suggestion and navigation test is passed.");
             }
             else
             {
                 System.Console.WriteLine("The Suggestion and navigation test is failed.");
             }

            driver.Quit();
        }
       
                
    }
}