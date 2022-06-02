// See https://aka.ms/new-console-template for more information



using My_First_Project.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

        

   //Open Chrome Browser
   IWebDriver driver = new ChromeDriver();

//call function(methods)in other class through objects,to call object

//loginPage object initialization and definition
LoginPage loginpageobj = new LoginPage();
loginpageobj.LoginSteps(driver);

//HomePage object initialization and definition
HomePage homeageobj = new HomePage();
homeageobj.GoToTMPage(driver);

//Classname obj = new classname();
//obj.method();

//TMPage object initialization and definition
TMPage tmpageobj = new TMPage();
tmpageobj.CreateTM(driver);


//EditTM object initialization and definition
TMPage tmpageobj = new TMPage();
tmpageobj.EditTM(driver);

//DeleteTM object initialization and definition
TMPage tmpageobj = new TMPage();
tmpageobj.DeleteTM(driver);