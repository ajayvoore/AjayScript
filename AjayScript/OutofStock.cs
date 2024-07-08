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
    public class OutofStock : BaseClass
    {
        [TestMethod]
        public void OutofStockproduct()
        {
            Thread.Sleep(4000);
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("iphone 6");
            Thread.Sleep(3000);
            System.Console.WriteLine("Locating the Search bar element and keyword laptop is typed");

            driver.FindElement(By.Id("nav-search-submit-button")).SendKeys(Keys.Enter);
            Thread.Sleep(4000);
            //driver.FindElement(By.XPath("")).Click();
            driver.Navigate().GoToUrl("https://www.amazon.in/Original-Smartphone-Compatible-iPhone-Warranty/dp/B0D5BGQCDK/ref=sr_1_4?crid=3OS8VTLW99PX7&dib=eyJ2IjoiMSJ9.I2y7dLjYAxFzzfY4dpu4M73_5fNHvOytS51LSm8fQ0pXn17e8kLCrPDutd2IDNZaKc1DAF0z-XVIUpcjljD5pvsfHPRAxQSDJK1VRgdvrfU4ZZqTGqPpmlKXJ2RV5j0m5qclBiJCaceOJxSinFvw4bW9labGEHy-N7RWDbF8pR1RufOfZM5QGfGNG-Q8TDSHDIwxN33juDX3vNAW3-sn20rfWVv8sqZj2g-dbu3PvHY.bd2OlDnnRF_7oGktqitlwfjesxlX7XM5Xr9-pycnqnE&dib_tag=se&keywords=iphone+6&qid=1720025818&sprefix=iphone+6%2Caps%2C246&sr=8-4");
            Thread.Sleep(9000);
            string s1 = driver.FindElement(By.XPath("//*[@id=\"outOfStock\"]/div/div[1]/span[1]")).Text;

            System.Console.WriteLine(s1);
            string s2 = "Currently unavailable.";
            if (s1.Equals(s2))
            {
                System.Console.WriteLine("The Invalid Test Out of Stock product adding to cart test is Passed");
            }
            else
            {
                System.Console.WriteLine("The Invalid Test Out of Stock product adding to cart test is Failed");
            }
            Thread.Sleep(3000);

            driver.Quit();

        }
    }
}
