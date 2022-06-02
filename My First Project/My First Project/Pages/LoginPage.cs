using My_First_Project.Utilties;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
           

            //launch Turnup Url
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //Maximize Window
            driver.Manage().Window.Maximize();

            WaitHelpers.waitElementToBeVisible(driver, "Id", "UserName", 3);
            //identify usernametextbox and enter valid username
            IWebElement usernametextbox = driver.FindElement(By.Id("UserName"));
            usernametextbox.SendKeys("hari");
            //driver.FindElement(By.Id("UserName")).SendKeys("hari");


            WaitHelpers.WaitElementToBeVisible(driver, "Id", "Password", 3);
            //identify Password textbox and enter valid password
            IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
            passwordtextbox.SendKeys("123123");
            //driver.FindElement(By.Id("Password")).SendKeys("123123");


            WaitHelpers.WaitElementToBeClickable(driver, "Xpath", "//*[@id='loginForm']/form/div[3]/input[1]", 3);
            //identify login button and click
            IWebElement Loginbutton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            Loginbutton.Click();
            //driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();


            WaitHelpers.WaitElementToBeVisible(driver, "Xpath", "//*[@id='logoutForm']/ul/li/a", 5);
            //check if the user has logged in successfully
            IWebElement Hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));


            if (Hellohari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in Successfully,test passed");

            }

            else
            {
                Console.WriteLine("Login fail,Test failed");
            }

        }
    }
}
