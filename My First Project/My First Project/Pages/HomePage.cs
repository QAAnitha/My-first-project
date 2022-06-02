using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Pages
{
    public class HomePage

    {
        public void GoToTMPage(IWebDriver driver)
        {
            //Click on Administration
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();
            //driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            Thread.Sleep(1000);
            //Click on Time & Materials from DropDown list
            IWebElement TM = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TM.Click();
            // driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();

        }

    }
}
