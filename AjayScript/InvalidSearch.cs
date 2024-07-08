using AjayScript.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjayScript
{
    [TestClass]
    public class InvalidSearch : BaseClass
    {
        [TestMethod]
        public void InvalidSearchoption()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("invalid123/");
            System.Console.WriteLine("Locating the Search bar element and keyword xyz123 is typed");

            driver.FindElement(By.Id("nav-search-submit-button")).SendKeys(Keys.Enter);
            Thread.Sleep(3000);

            string search = driver.FindElement(By.XPath("//*[@id=\"search\"]/div[1]/div[1]/div/span[1]/div[1]/div[1]/div/div/div/div[1]")).Text;
            NUnit.Framework.Assert.That(search, Is.EqualTo("No results for invalid123/."));
            System.Console.WriteLine(search);

            driver.Quit();

        }
    }
}
