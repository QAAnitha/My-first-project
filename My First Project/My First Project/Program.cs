// See https://aka.ms/new-console-template for more information




//open chrome browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();


//launch Turnup Url
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//Maximize Window
driver.Manage().Window.Maximize();

Thread.Sleep(1000);
//identify usernametextbox and enter valid username
IWebElement usernametextbox = driver.FindElement(By.Id("UserName"));
usernametextbox.SendKeys("hari");

Thread.Sleep(1000);
//identify Password textbox and enter valid password
IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
passwordtextbox.SendKeys("123123");

Thread.Sleep(1000);
//identify login button and click
IWebElement Loginbutton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
Loginbutton.Click();

Thread.Sleep(1000);
//check if the user has logged in successfully
IWebElement Hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if(Hellohari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in Successfully,test passed");

}

else
{
    Console.WriteLine("Login fail,Test failed");
}
