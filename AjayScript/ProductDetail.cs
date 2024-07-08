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
    public class ProductDetail : BaseClass
    {
        [TestMethod]

        public void ProductDetailPage()
        {
            //Locating the search bar and in it keyword laptop brand and price is searched
            Thread.Sleep(2000);

            driver.Navigate().GoToUrl("https://www.amazon.in/HP-15-6inch-Micro-Edge-Anti-Glare-15s-Eq2143au/dp/B09R1MMMTH/ref=sr_1_1?crid=20OMG38S7A58T&dib=eyJ2IjoiMSJ9.PZw1R_2nKbbpi1mPb6oEcC2ttSqtlwyTbPwJssaGHrFDnH7x_3hfVgIkCw_vKavrIlMd3rpyzoxAf-rhjZ68uDcp9aI9N4QSmHYIeyG94OLgpcRZDnl-2WBHN77wJgpND8ZScYnkB5QmnR0JoQcUMpp-wDXCoyK2fmt-WhVSzYhlcj-aBYv_oeV_HPinpP0vIDVyqgZY76sOCa5hKiIYafsTQxdv-Q8M4GjO8H-q7Ag.A6YHVnJybHRr4mBnIMPoWbWijM0nsnpAZlgYPlAFr14&dib_tag=se&keywords=HP+Laptop+15s%2C+AMD+Ryzen+3+5300U%2C+15.6-inch+%2839.6+cm%29%2C+FHD%2C+8GB+DDR4%2C+512GB+SSD%2C+AMD+Radeon+graphics%2C+Thin+%26+light%2C+Dual+speakers+%28Win+11%2C+MSO+2019%2C+Silver%2C+1.69+kg%29%2C+eq2143AU+%3A+Amazon.in%3A+Electronics&nsdOptOutParam=true&qid=1720027697&sprefix=hp+laptop+15s%2C+amd+ryzen+3+5300u%2C+15.6-inch+39.6+cm+%2C+fhd%2C+8gb+ddr4%2C+512gb+ssd%2C+amd+radeon+graphics%2C+thin+%26+light%2C+dual+speakers+win+11%2C+mso+2019%2C+silver%2C+1.69+kg+%2C+eq2143au+amazon.in+electronics%2Caps%2C221&sr=8-1");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"prodDetails\"]")).Click();
            Thread.Sleep(6000);

            System.Console.WriteLine(driver.Title);
            driver.FindElement(By.Id("prodDetails")).Click();

            Thread.Sleep(3000);
            string actualTitle4 = driver.Title;
            string expectedTitle4 = "HP Laptop 15s, AMD Ryzen 3 5300U, 15.6-inch (39.6 cm), FHD, 8GB DDR4, 512GB SSD, AMD Radeon graphics, Thin & light, Dual speakers (Win 11, MSO 2019, Silver, 1.69 kg), eq2143AU : Amazon.in: Electronics";
            if (actualTitle4.Equals(expectedTitle4))
            {
                System.Console.WriteLine("The Product details test is passed.");
            }
            else
            {
                System.Console.WriteLine("The Product details test is failed.");
            }

            Thread.Sleep(3000);

            string s1 = driver.FindElement(By.XPath("//*[@id=\"availability\"]")).Text;

            System.Console.WriteLine(s1);
            string s2 = "In stock";
            if (s1.Equals(s2))
            {
                System.Console.WriteLine("The Product Availability test is Passed");
            }
            else
            {
                System.Console.WriteLine("The Product Availability test is Failed");
            }
            Thread.Sleep(3000);

            string s3 = driver.FindElement(By.XPath("//*[@id=\"corePriceDisplay_desktop_feature_div\"]/div[1]/span[3]/span[2]/span[2]")).Text;
            //System.Console.WriteLine(s3);
            System.Console.WriteLine("The Product Price is " + s3);

            driver.FindElement(By.Id("product-comparison_feature_div")).Click();
            Thread.Sleep(2000);

            driver.Quit();

        }
    }
}
