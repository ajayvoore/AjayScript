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
    public class InvalidPincode : BaseClass
    {

        [TestMethod]
        public void Pincode()
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


            driver.FindElement(By.XPath("//*[@id=\"contextualIngressPtLabel_deliveryShortLine\"]")).Click();
            Thread.Sleep(3000);
            IWebElement pincode = driver.FindElement(By.Id("GLUXZipUpdateInput"));
            Thread.Sleep(1000);
            pincode.SendKeys("111111");
            pincode.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            bool error = driver.FindElement(By.XPath("//*[@id=\"GLUXZipError\"]")).Displayed;

            System.Console.WriteLine(error+" enter a valid pincode");
                        
            driver.Quit();
        }
    }
}
