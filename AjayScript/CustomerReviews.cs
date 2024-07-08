using OpenQA.Selenium;
using AjayScript.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjayScript
{
    public class CustomerReviews : BaseClass
    {
        [TestMethod]
        public void CustomerReviewsandRatings()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("laptop");
            System.Console.WriteLine("Locating the Search bar element and keyword laptop is typed");

            driver.FindElement(By.Id("nav-search-submit-button")).SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            //driver.FindElement(By.XPath("//*[@id=\"search\"]/div[1]/div[1]/div/span[1]/div[1]/div[5]/div/div/span/div/div/div/div[2]/div/div/div[1]/h2/a/span")).Click();
            driver.Navigate().GoToUrl("https://www.amazon.in/Lenovo-IdeaPad-Celeron-Warranty-82V6009LIN/dp/B0D6Z2H2HR/ref=sr_1_3?crid=3LTKXT44ZJCCJ&dib=eyJ2IjoiMSJ9.Ncox-pQSujxlzFQ5OHn-IPpJNeeo46N8TJ-AzrJunh6NP8zrqiySApiJQKgDIRf41mcspGbwChD8ZYZ_qEW-keK5VbrwmZ3Th6oSI9tWALnoMeRTEYD5QX9_qYfJwH4UhNIWBX-KZEvCHwDWWX513G1gsX9OLH1VcezH4YFylYxPRprUw0GTIjglmLKXJnKaenbso3SFeG0PManTKtOvZY5SULJXqwvjH-feiQ_q4zk.WRn8bjL-L_y-QBM4WB_7BaTi3rKofLf9cDIgda4HYRM&dib_tag=se&keywords=laptop&qid=1720082874&sprefix=laptop%2Caps%2C375&sr=8-3");
            Thread.Sleep(9000);

            System.Console.WriteLine(driver.Title);
            driver.FindElement(By.XPath("//*[@id=\"acrCustomerReviewLink\"]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"a-autoid-31-announce\"]")).Click();
            //driver.FindElement(By.CssSelector("#a-autoid-48-announce")).Click();
            Thread.Sleep(3000);
            
            driver.Quit();

        }
    }
}
