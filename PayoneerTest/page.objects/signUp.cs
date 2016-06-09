using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PayoneerTest.page.objects
{
    class signUp : tools.selenium
    {
        String URL = "https://payouts.sandbox.payoneer.com/partners/or.aspx?pid=Y0LwV0AQC7cY%2b5AIqsZl1g%3d%3d%20&langid=1";


        //CC option
        [FindsBy(How = How.Id, Using = "payoutMethods_4")]
        public IWebElement slcCC { get; set; }

        //bank transfer option
        [FindsBy(How = How.Id, Using = "payoutMethods_1")]
        public IWebElement slcWire { get; set; }

        //sign up button
        [FindsBy(How = How.Id, Using = "SignUpButton")]
        public IWebElement btnSU { get; set; }

        //company option
        [FindsBy(How = How.Id, Using = "accountType_Company")]
        public IWebElement btnCompeny { get; set; }

        //first name field
        [FindsBy(How = How.Id, Using = "txtFirstName")]
        public IWebElement txtFirstName { get; set; }

        //last name field
        [FindsBy(How = How.Id, Using = "txtLastName")]
        public IWebElement txtLastName { get; set; }

        //email field
        [FindsBy(How = How.Id, Using = "txtEmail")]
        public IWebElement txtEmail { get; set; }

        //email validation field
        [FindsBy(How = How.Id, Using = "txtRetypeEmail")]
        public IWebElement txtRetypeEmail { get; set; }

        //birthday field
        [FindsBy(How = How.Id, Using = "datepicker5")]
        public IWebElement txtdatepicker5 { get; set; }

        //birthday month field
        [FindsBy(How = How.XPath, Using = "//div[@id='ui-datepicker-div']/div/div/select[@data-handler='selectMonth']")]
        public IWebElement ddMonth { get; set; }

        //birthday year field
        [FindsBy(How = How.XPath, Using = "//div[@id='ui-datepicker-div']/div/div/select[@data-handler='selectYear']")]
        public IWebElement ddYear { get; set; }

        //company birthday field
        [FindsBy(How = How.Id, Using = "datepicker")]
        //[FindsBy(How = How.XPath, Using = "//div[@class='form-object Individual']/div/button[@class='ui-datepicker-trigger']")]
        public IWebElement datepicker { get; set; }

        //companys name field
        [FindsBy(How = How.Id, Using = "txtCompanyName")]
        public IWebElement txtCompanyName { get; set; }

        //companys legal entity field
        [FindsBy(How = How.Id, Using = "ddlBusinessOrganization")]
        public IWebElement ddCompanyLegalEntity { get; set; }

        //companys url field
        [FindsBy(How = How.Id, Using = "txtCompanyURL")]
        public IWebElement txtCompanyURL { get; set; }

        //companys contact first name field
        [FindsBy(How = How.Id, Using = "txtContactPersonFirstName")]
        public IWebElement txtContactPersonFirstName { get; set; }

        //companys contact last name field
        [FindsBy(How = How.Id, Using = "txtContactPersonLastName")]
        public IWebElement txtContactPersonLastName { get; set; }

        //1st stage next button
        [FindsBy(How = How.Id, Using = "arrowForward")]
        public IWebElement btnNext { get; set; }

        //address field
        [FindsBy(How = How.Id, Using = "txtAddress3")]
        public IWebElement txtAddress { get; set; }


        //2nd address field
        [FindsBy(How = How.Id, Using = "txtAddress4")]
        public IWebElement txtAddress2 { get; set; }

        //city field
        [FindsBy(How = How.Id, Using = "txtCity")]
        public IWebElement txtCity { get; set; }

        //zip code field
        [FindsBy(How = How.Id, Using = "txtZip")]
        public IWebElement txtZip { get; set; }

        //phone num field
        [FindsBy(How = How.Id, Using = "ContactPersonPhoneNumber_num")]
        public IWebElement txtPhoneNumber { get; set; }

        //1st password field
        [FindsBy(How = How.Id, Using = "tbPassword")]
        public IWebElement txtPassword { get; set; }

        //2nd password field
        [FindsBy(How = How.Id, Using = "tbRetypePassword")]
        public IWebElement txtRetypePassword { get; set; }

        //security question field
        [FindsBy(How = How.Id, Using = "ddlSecurityQuestions")]
        public IWebElement ddlSecurityQuestions { get; set; }

        //1st security question field
        [FindsBy(How = How.XPath, Using = "//select[@id='ddlSecurityQuestions']/option[2]")]
        public IWebElement ddlSecurityQuestionsOption { get; set; }

        //security answer field
        [FindsBy(How = How.Id, Using = "tbSecurityAnswer")]
        public IWebElement txtSecurityAnswer { get; set; }

        //birth country field
        [FindsBy(How = How.Id, Using = "ddlCountryOfBirth")]
        public IWebElement ddlCountryOfBirth { get; set; }

        //nationality country field
        [FindsBy(How = How.Id, Using = "ddlCountryOfNationality")]
        public IWebElement ddlCountryOfNationality { get; set; }

        //identity field
        [FindsBy(How = How.Id, Using = "ddlIdentity")]
        public IWebElement ddlIdentity { get; set; }

        //1st sign document  field
        [FindsBy(How = How.Id, Using = "SignDocument_4_2")]
        public IWebElement ckbSignDocument1 { get; set; }

        //2nd sign document  field
        [FindsBy(How = How.Id, Using = "SignDocument_3_10")]
        public IWebElement ckbSignDocument2 { get; set; }

        //3rd sign document  field
        [FindsBy(How = How.Id, Using = "SignDocument_207")]
        public IWebElement ckbSignDocument3 { get; set; }

        //ID num field
        [FindsBy(How = How.Id, Using = "tbIDOnCard")]
        public IWebElement txtIDOnCard { get; set; }

        //ID Issue Place field
        [FindsBy(How = How.Id, Using = "ddlIDCardIssuePlace")]
        public IWebElement ddlIDCardIssuePlace { get; set; }

        //submit form button
        //[FindsBy(How = How.Id, Using = "btnSubmit")]
        [FindsBy(How = How.XPath, Using = "//div[@class='full-page']/div/div/span/input[@id='btnSubmit']")]
        public IWebElement btnSubmit { get; set; }


        
        //last stage ifrme
        [FindsBy(How = How.Id, Using = "iframMR")]
        public IWebElement frmMR { get; set; }


        public signUp()
        {
            PageFactory.InitElements(driver, this);
        }

        public void init()
        {
            PageFactory.InitElements(driver, this);
        }

        public void loadPage()
        {
            driver.Url = URL;
            PageFactory.InitElements(driver, this);
        }
        public void clickOnSignUp()
        {
            btnSU.Click();
        }

        public void clickOnCC()
        {
            slcCC.Click();
        }

        public void clickOnWire()
        {
            slcWire.Click();
        }

        public void clickOnCompeny()
        {
            btnCompeny.Click();
        }
        public void enterFirstName(String firstname)
        {
            txtFirstName.SendKeys(firstname);
        }

        public void enterLastName(String lastname)
        {
            txtLastName.SendKeys(lastname);
        }

        public void enterEmailAddress(String email)
        {
            txtEmail.SendKeys(email);
            txtRetypeEmail.SendKeys(email);
        }

        public void enterIndividualBirthDay(String birthday)
        {
            txtdatepicker5.SendKeys(birthday);
        }

        public void enterCompanyBirthDay(String day, String month, String year)
        {
            datepicker.Click();
            selectByValue(ddMonth, month);
            selectByValue(ddYear, year);
            //datePicker("//div[@id='ui-datepicker-div']/table/tbody/tr/td/a", day);
        }


        public void enterCompanyName(String name)
        {
            txtCompanyName.SendKeys(name);
        }

        public void enterCompanyLegalEntity(int ID)
        {
            selectByIndex(ddCompanyLegalEntity, ID);
        }
        public void enterCompanyURL(String URL)
        {
            txtCompanyURL.SendKeys(URL);
        }
        public void enterContactFirstName(String name)
        {
            txtContactPersonFirstName.SendKeys(name);
        }
        public void enterContactLastName(String name)
        {
            txtContactPersonLastName.SendKeys(name);
        }

        public void fill_1stStage()
        {
            System.Threading.Thread.Sleep(5000);
            clickOnCC();
            clickOnSignUp();
            clickOnCompeny();
            enterCompanyName("Some company name");
            enterCompanyLegalEntity(2);
            enterCompanyURL("https://il.linkedin.com/in/yuval-glasman-04bab651");
            enterContactFirstName("Yuval");
            enterContactLastName("Glasman");
            String time = tools.time.getCurrentDate();
            enterEmailAddress("yuval" + time + "@mailinator.com");
            enterCompanyBirthDay("1", "1", "1980");
            btnNext.Click();
        }

        public void enterAddress(String add)
        {
            txtAddress.SendKeys(add);
        }

        public void enter2ndAddress(String add)
        {
            txtAddress2.SendKeys(add);
        }

        public void enterCity(String city)
        {
            txtCity.SendKeys(city);
        }

        public void enterZipCode(String code)
        {
            txtZip.SendKeys(code);
        }

        public void enterPhoneNum(String num)
        {
            txtPhoneNumber.SendKeys(num);
        }

        public void fill_2ndStage()
        {
            enterAddress("address");
            enter2ndAddress("2nd address");
            enterCity("some city");
            enterZipCode("12345");
            enterPhoneNum("123456789");
            btnNext.Click();
        }

        public void enterPassword(String pass)
        {
            txtPassword.SendKeys(pass);
        }

        public void enterPasswordValidation(String pass)
        {
            txtRetypePassword.SendKeys(pass);
        }

        public void selectFirstSecurityQuestions()
        {
            selectByText(ddlSecurityQuestions, ddlSecurityQuestionsOption.Text);
        }

        public void enterSecurityAnswer(String ans)
        {
            txtSecurityAnswer.SendKeys(ans);
        }

        public void fill_3rdStage()
        {
            enterPassword("1q2W3e4R");
            enterPasswordValidation("1q2W3e4R");
            selectFirstSecurityQuestions();
            enterSecurityAnswer("some answer");
            btnNext.Click();
        }



        public void enterCountryOfBirth(String text)
        {
            selectByText(ddlCountryOfBirth, text);

        }

        public void enterCountryOfNationality(String text)
        {
            selectByText(ddlCountryOfNationality, text);

        }

        public void enterlIdentity(String text)
        {
            selectByText(ddlIdentity, text);
        }

        public void agreeToTC()
        {
            ckbSignDocument1.Click();
            ckbSignDocument2.Click();
            ckbSignDocument3.Click();
        }

        public void enterIdNum(String num)
        {
            txtIDOnCard.SendKeys(num);
        }
        public void enterIdIssueCountry(String text)
        {
            selectByText(ddlIDCardIssuePlace, text);
        }


        public void submitForm()
        {
            btnSubmit.Click();
        }

        public void fill_4thStage()
        {
            switchToIframe(frmMR);
            enterCountryOfBirth("Israel");
            enterCountryOfNationality("Israel");
            enterlIdentity("National ID");
            agreeToTC();
            enterIdNum("123456789");
            enterIdIssueCountry("Israel");
            //wait for the button to be clickable
            System.Threading.Thread.Sleep(2000);
            submitForm();
            returnFromIframe();
        }
    }
}
