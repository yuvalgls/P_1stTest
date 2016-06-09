using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using PayoneerTest.page.objects;

namespace PayoneerTest
{
    [TestClass]
    public class UnitTest1 : tools.selenium
    {
        [TestInitialize()]
        public void setUp()
        {
            setFireFoxDriver();
        }

        [TestCleanup()]
        public void Cleanup()
        {
            killDriver();   
        }
        
        [TestMethod]
        public void TestMethod1()
        {
            signUp su = new signUp();
            su.loadPage();
            su.fill_1stStage();
            su.fill_2ndStage();
            su.fill_3rdStage();
            su.fill_4thStage();
            //Assert.
        }
    }
}
