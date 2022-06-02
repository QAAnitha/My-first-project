using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Waits
//Implicit and Explicit Wait and Fluent Wait//


namespace My_First_Project.Utilties //Project Name
{
    public class WaitHelpers //class name
    {
        //Generic Function to wait for ElementToBeClickable
        public static void WaitElementToBeClickable(IWebDriver driver, string locator, string locatorvalue, int seconds)//method
        {
            var wait = new WebDriverwait(driver, new TimeSpan(0, 0, seconds));

            if (locator == "Xpath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorvalue)));

            }
            if (locator == "id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorvalue)));

            }

            if (locator == "CssSelector")

            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorvalue)));
            }

        }

        internal static void waitElementToBeVisible(IWebDriver driver, string v1, string v2, int v3)
        {
            throw new NotImplementedException();
        }



        //Generic Function to wait for ElementToBeVisible

        public static void WaitElementToBeVisible(IWebDriver driver, string locator, string locatorvalue, int seconds)
        {
            var wait = new WebDriverwait(driver, new TimeSpan(0, 0, seconds));


            if (locator == "Xpath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorvalue)));
            }
            if (locator == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorvalue)));
            }
            if (locator == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(locatorvalue)));
            }
        }

        //Generic Function wait for ElementToBeExistent

        public static void waitElementToBeExistent(IWebDriver driver, String locator, string locatorvalue, int seconds)
        {
            var wait = new WebDriverwait(driver, new TimeSpan(0, 0, seconds));


            if (locator == "Xpath")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorvalue)));
            }
            if(locator =="Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorvalue)));
            }
            if (locator == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locatorvalue)));
            }
        }


    }

}






