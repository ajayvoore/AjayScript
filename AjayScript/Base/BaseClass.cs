using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjayScript.Base
{
    public class BaseClass
    {
        public IWebDriver driver;
        
        public BaseClass() 
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.amazon.in";
            Thread.Sleep(2000);
            driver.Manage().Window.Maximize();
                       

        }
        [TearDown]
        public void Close() {driver.Quit(); }
    }
}
