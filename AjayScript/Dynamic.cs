using AjayScript.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace AjayScript
{
    [TestClass]
    public class Dynamic : BaseClass
    {

        [TestMethod]
        public void DynamicContent()
        {
            Thread.Sleep(4000);
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("laptop");
            Thread.Sleep(3000);
            System.Console.WriteLine("Locating the Search bar element and keyword laptop is typed");

            driver.FindElement(By.Id("nav-search-submit-button")).SendKeys(Keys.Enter);
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//*[@id=\"search\"]/div[1]/div[1]/div/span[1]/div[1]/div[5]/div/div/span/div/div/div/div[2]/div/div/div[1]/h2/a/span")).Click();
            Thread.Sleep(9000);
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);

            Actions actions = new Actions(driver);
            for (int i = 0; i < 15; i++) // Scroll multiple times to ensure all dynamic content is loaded
            {
                actions.SendKeys(Keys.PageDown).Perform();
                Thread.Sleep(1500); // Wait for dynamic content to load
            }
                      
            try
                {
                    var moreReviews = driver.FindElement(By.XPath("//div[contains(@id,'customer_review')]")); 
                    // Adjust the locator as per actual dynamic content element
                    System.Console.WriteLine(moreReviews.Displayed);
                }
            catch (NoSuchElementException)
                {
                System.Console.WriteLine(false);
                }
            driver.Quit();

            
        }             

    }
    
}
