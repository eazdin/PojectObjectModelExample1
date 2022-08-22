using System.Lind;
using System.Threadling;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;
using System;
namespace PageClassLib
{
    public class HomePage
    {
      
        private IWebDriver Driver;

        [FindBy(How = How.LinkText, Using = "DROPDOWN, CHECKBOXE(S) & RADIO BUTTON(S)")]

        private IWebElement _LinkText;



        public HomePage (IWebDriver,driver){

            // driver=driver;
            
            
        }  
    }
}