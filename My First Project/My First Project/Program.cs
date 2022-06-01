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
//driver.FindElement(By.Id("UserName")).SendKeys("hari");


Thread.Sleep(1000);
//identify Password textbox and enter valid password
IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
passwordtextbox.SendKeys("123123");
//driver.FindElement(By.Id("Password")).SendKeys("123123");


Thread.Sleep(1000);
//identify login button and click
IWebElement Loginbutton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
Loginbutton.Click();
//driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();


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

//Click on Administration
IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administration.Click();
//driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

Thread.Sleep(1000);
//Click on Time & Materials from DropDown list
IWebElement TM = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
TM.Click();
// driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();


//Click on Create new Button
IWebElement Createnewbutton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
Createnewbutton.Click();
//driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();


// Identify TypecodeDropdown
IWebElement TypecodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
TypecodeDropdown.Click();
//driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();

Thread.Sleep(1000);
//Select Material from Typecode Dropdown
IWebElement Material = driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']"));
Material.Click();
// driver.FindElement(By.XPath("//*[@id="TypeCode_option_selected"]")).Click();

Thread.Sleep(1000);
//Select Time from Typecode Dropdown
IWebElement Time = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span"));
Time.Click();
//driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span")).Click();


// Identify the code Textbox and enter a valid code
IWebElement CodeTextBox = driver.FindElement(By.Id("Code"));
CodeTextBox.SendKeys("Testing");
//driver.FindElement(By.Id("Code")).SendKeys("Testing");



//Identify the Description Textbox and enter a valid Description
IWebElement DescriptionTextBox = driver.FindElement(By.Id("Description"));
DescriptionTextBox.SendKeys("Testing");
//driver.FindElement(By.Id("Description")).SendKeys("Testing");


Thread.Sleep(1000);
//Identify the price per unit Textbox and enter price value
IWebElement PriceTextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
PriceTextbox.Click();
IWebElement price = driver.FindElement(By.Id("Price"));
price.SendKeys("120");
//driver.FindElement(By.Id("Price")).SendKeys("$120.00");



//Click Save Button
IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
SaveButton.Click();
//driver.FindElement(By.Id("SaveButton")).Click();

Thread.Sleep(2000);
//Click on go to the Last page button
IWebElement goLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
goLastPageButton.Click();
//note:goLastPageButton (Lower,upper,uppercase)

Thread.Sleep(2000);
//Check Material record Created
IWebElement newMaterialRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

if (newMaterialRecordCreated.Text == "Testing") 

{
    Console.WriteLine("New MaterialRecord Created", "testpassed");
}

else
{
    Console.WriteLine("New Material Record Hasn't been Created", "Test failed");
}


//Edit Material Record//
Thread.Sleep(1000);
//Identify Edit Button and click
IWebElement EditButton = driver.FindElement (By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]"));
EditButton.Click();

Thread.Sleep(1000);
//Identify Typecode Dropdown and Select Material Dropdown
IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label"));
typeCodeDropdown.Click();

IWebElement materialDropDown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
materialDropDown.Click();

Thread.Sleep(1000);
//Identify codetextbox and clear and editinput
IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
codeTextBox.Clear();
codeTextBox.SendKeys("Sheep");

Thread.Sleep(1000);
//Identify descriptionTextBox and clear and editinput
IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
descriptionTextBox.Clear();
descriptionTextBox.SendKeys("Sheep");

Thread.Sleep(1000);
//Identify the priceperunitTextbox and enter price value
IWebElement priceedit = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
priceedit.Click();
IWebElement priceEditBox = driver.FindElement(By.Id("Price"));
priceEditBox.Clear();
priceEditBox.SendKeys("320");

//driver.FindElement(By.Id("Price")).SendKeys("200.00");


Thread.Sleep(1000);
//Click Save Button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();

Thread.Sleep(1000);
//Check MaterialRecordEdited in the FirstPageSuccessfully or not
IWebElement materialrecordeditedcolumn = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/ul/li[first()]/span"));

if (materialrecordeditedcolumn.Text == "Sheep")
{
    Console.WriteLine("Material Record Edited Successfully","Test passed");
}
else
{
    Console.WriteLine("Material Record Not Edited", "Test Failed");

}

Thread.Sleep(1000);
//delete material Record//

//identify and click delete button in Material record
IWebElement deleteMaterialRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[20]/td[5]/a[2]"));
deleteMaterialRecord.Click();

Thread.Sleep(1000);
//Alert popup msg 
Console.WriteLine("Delete button clicked");

IAlert alert = driver.SwitchTo().Alert();
alert.Accept();


//driver.SwitchTo().Alert().Accept();
Console.WriteLine("OK button Clicked");


Thread.Sleep(1000);

//Check the selectedMaterialRecord is Deleted or not

IWebElement deletedMaterialRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[7]/td[5]/a[2]"));

if (deletedMaterialRecord.Text != "Sheep")
{
    Console.WriteLine("Material selected record deleted Successfully");
}
else
{
    Console.WriteLine("Material selected record not deleted ");
}

Thread.Sleep(1000);
//Logout Hello hari//

// Identify and Click Hello hari
IWebElement logoutButton = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
logoutButton.Click();

//Identify log off button and click
IWebElement logoff = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/ul/li[2]/a"));
logoff.Click();

driver.Close();
