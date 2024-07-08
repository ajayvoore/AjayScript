using NUnit.Framework;
using OpenQA.Selenium;
using AjayScript.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjayScript
{
    [TestClass]
    public class AddtoCart : BaseClass
    {

        [TestMethod]
        public void AddtoCartProduct()
        {
            Thread.Sleep(4000);
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("laptop");
            System.Console.WriteLine("Locating the Search bar element and keyword laptop is typed");

            driver.FindElement(By.Id("nav-search-submit-button")).SendKeys(Keys.Enter);

            IWebElement Prod = driver.FindElement(By.XPath("//*[@id=\"search\"]/div[1]/div[1]/div/span[1]/div[1]/div[5]/div/div/span/div/div/div/div[2]/div/div/div[1]/h2/a/span"));
            Prod.Click();
            string prodWindow = driver.WindowHandles[1];
            driver.SwitchTo().Window(prodWindow);
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//div[@class='a-section a-spacing-none a-padding-none']//input[@id='add-to-cart-button']")).Click();
            Thread.Sleep(6000);
            string msgText = driver.FindElement(By.XPath("//*[@id=\"attachDisplayAddBaseAlert\"]/div/h4")).Text;
            NUnit.Framework.Assert.That(msgText, Is.EqualTo("Added to Cart"));
            Thread.Sleep(2000);
            Console.WriteLine(msgText);

            driver.Quit();

        }
    }
}
