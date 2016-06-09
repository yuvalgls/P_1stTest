using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PayoneerTest.tools
{
    public class selenium
    {
        public static IWebDriver driver;

        public void setFireFoxDriver()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(90));
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(90));
        }

        public void killDriver()
        {
            driver.Quit();
        }

        public void selectByIndex(IWebElement elementPath, int index)
        {
            SelectElement element = new SelectElement(elementPath);
            element.SelectByIndex(index);
        }

        public void selectByText(IWebElement elementPath, String text)
        {
            SelectElement element = new SelectElement(elementPath);
            element.SelectByText(text);
        }

        public void selectByValue(IWebElement elementPath, String value)
        {
            SelectElement element = new SelectElement(elementPath);
            element.SelectByValue(value);
        }

        public void datePicker(String elementPath, String date)
        {
            ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.XPath(elementPath));
            foreach (IWebElement element in elements)
            {
                if (element.Text.Equals(date))
                {
                    element.Click();
                }
            }
        }

        public void clickOnElement(String elementPath)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(elementPath)));
            IWebElement element = driver.FindElement(By.Id("elementPath"));
            element.Click();
        }

        public void waitForElementToBeVisible(String elementPath)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id(elementPath)));
        }

        public void switchToIframe(IWebElement element)
        {
            driver.SwitchTo().Frame(element);
        }
        public void returnFromIframe()
        {
            driver.SwitchTo().DefaultContent();
        }
    }
}