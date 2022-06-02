using My_First_Project.Utilties;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            //Click on Create new Button
            IWebElement Createnewbutton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            Createnewbutton.Click();
            //driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();


            // Identify TypecodeDropdown
            IWebElement TypecodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            TypecodeDropdown.Click();
            //driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();

            //Fluentwait classname.methodname(dr,stringlocator,stringlocatorvalue,int seconds)
            WaitHelpers.WaitElementToBeClickable(driver, "Xpath","//*[@id='TypeCode_option_selected']",5);

            //Another way
            //create obj for wait
           // WaitHelpers WaitHelpersobj = new WaitHelpers();
            //WaitHelpersobj.WaitElementToBeClickable(driver, "Xpath", "//*[@id='TypeCode_option_selected']", 5);

            //Select Material from Typecode Dropdown
            IWebElement Material = driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']"));
            Material.Click();
            // driver.FindElement(By.XPath("//*[@id="TypeCode_option_selected"]")).Click();

            WaitHelpers.WaitElementToBeClickable(driver, "Xpath", "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span", 3);
            //Select Time from Typecode Dropdown
            IWebElement Time = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span"));
            Time.Click();
            //driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span")).Click();


            WaitHelpers.WaitElementToBeVisible(driver, "Id", "Code", 5);
            // Identify the code Textbox and enter a valid code
            IWebElement CodeTextBox = driver.FindElement(By.Id("Code"));
            CodeTextBox.SendKeys("Testing");
            //driver.FindElement(By.Id("Code")).SendKeys("Testing");


            WaitHelpers.WaitElementToBeVisible(driver, "Id", "Description", 3);
            //Identify the Description Textbox and enter a valid Description
            IWebElement DescriptionTextBox = driver.FindElement(By.Id("Description"));
            DescriptionTextBox.SendKeys("Testing");
            //driver.FindElement(By.Id("Description")).SendKeys("Testing");


            WaitHelpers.WaitElementToBeClickable(driver, "Id", "Price", 3);
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

            WaitHelpers.WaitElementToBeVisible(driver, "Xpath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 5);
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

        }


        public void EditTM(IWebDriver driver)
        {

            //Edit Material Record//
            WaitHelpers.WaitElementToBeClickable(driver, "Xpath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]", 3);
            //Identify Edit Button and click
            IWebElement EditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]"));
            EditButton.Click();

            WaitHelpers.WaitElementToBeClickable(driver, "Xpath", "//*[@id='TimeMaterialEditForm']/div/div[1]/label", 5);
            //Identify Typecode Dropdown and Select Material Dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label"));
            typeCodeDropdown.Click();

            IWebElement materialDropDown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            materialDropDown.Click();

            WaitHelpers.WaitElementToBeVisible(driver, "Id", "Code", 3);
            //Identify codetextbox and clear and editinput
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.Clear();
            codeTextBox.SendKeys("Sheep");

            WaitHelpers.WaitElementToBeVisible(driver, "Id", "Description", 3);
            //Identify descriptionTextBox and clear and editinput
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.Clear();
            descriptionTextBox.SendKeys("Sheep");

            WaitHelpers.WaitElementToBeVisible(driver, "Id", "Price", 3);
            //Identify the priceperunitTextbox and enter price value
            IWebElement priceedit = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceedit.Click();
            IWebElement priceEditBox = driver.FindElement(By.Id("Price"));
            priceEditBox.Clear();
            priceEditBox.SendKeys("320");

            //driver.FindElement(By.Id("Price")).SendKeys("200.00");


            
            //Click Save Button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            WaitHelpers.WaitElementToBeVisible(driver, "Xpath", "//*[@id='tmsGrid']/div[4]/ul/li[first()]/span", 5);
            //Check MaterialRecordEdited in the FirstPageSuccessfully or not
            IWebElement materialrecordeditedcolumn = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/ul/li[first()]/span"));

            if (materialrecordeditedcolumn.Text == "Sheep")
            {
                Console.WriteLine("Material Record Edited Successfully", "Test passed");
            }
            else
            {
                Console.WriteLine("Material Record Not Edited", "Test Failed");

            }

        }

        public void DeleteTM(IWebDriver driver)
        {
            //delete material Record//

            WaitHelpers.WaitElementToBeClickable(driver, "Xpath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[20]/td[5]/a[2]", 5);
            //identify and click delete button in Material record
            IWebElement deleteMaterialRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[20]/td[5]/a[2]"));
            deleteMaterialRecord.Click();

            
            //Alert popup msg 
            Console.WriteLine("Delete button clicked");

           
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();


            //driver.SwitchTo().Alert().Accept();
            Console.WriteLine("OK button Clicked");



            WaitHelpers.WaitElementToBeVisible(driver, "Xpath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[7]/td[5]/a[2]",5);
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

          
            //Logout Hello hari//

            // Identify and Click Hello hari
            IWebElement logoutButton = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            logoutButton.Click();

            //Identify log off button and click
            IWebElement logoff = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/ul/li[2]/a"));
            logoff.Click();

            driver.Close();
        }
    }


}
