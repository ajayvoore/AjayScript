using AjayScript.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjayScript
{
    [TestClass]
    public class FilterandSort : BaseClass
    
    {
        [TestMethod]
        public void FilterandSortResults()
        {

            Thread.Sleep(3000);
            //Locating the search bar and in it keyword laptop brand and price is searched

            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("laptop");
            System.Console.WriteLine("Locating the Search bar element and keyword laptop is typed");

            driver.FindElement(By.Id("nav-search-submit-button")).SendKeys(Keys.Enter);
            System.Console.WriteLine("In search bar laptop is typed and searched");
            driver.FindElement(By.XPath("//*[@id=\"p_123/308445\"]/span/a/span")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"p_123/308445\"]/span/a/span")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"p_123/308445\"]/span/a/span")).Click();
            Thread.Sleep(2000);
            System.Console.WriteLine(driver.Title);
            string actualTitle3 = driver.Title;
            string expectedTitle3 = "Amazon.in: Laptop - 308445: Computers & Accessories";
            if (actualTitle3.Equals(expectedTitle3))
            {
                System.Console.WriteLine("The Results based on selected filter test is passed.");
            }
            else
            {
                System.Console.WriteLine("The Results based on selected filter test is failed.");
            }

            driver.Quit();
        }
    }
}
