using My_First_Project.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Utilties
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        LoginPage loginpageobj = new LoginPage();

    

    [OneTimeSetUp]
    public void LoginActions()
    {
        //Open Chrome Browser
        IWebDriver driver = new ChromeDriver();

        //Login page object initialization and definition
        LoginPage loginpageobj = new LoginPage();
        loginpageobj.LoginSteps(driver);

    }

    [OneTimeTearDown]
    public void CloseTestRun()
    {
        driver.Close();
        //driver.Quit();

       // instead of driverQuit using driverclose

    }
    }
}


//static returns the value
