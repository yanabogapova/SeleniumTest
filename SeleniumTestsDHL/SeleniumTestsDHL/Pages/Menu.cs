using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTestsDHL.Pages
{
    class Menu : BaseClass
    {
        [FindsBy(How = How.CssSelector, Using = "a[href*='/TPManagerDPDHLTest/?menuItem=TPadmin']")]
        private IWebElement tpAdminMenuElement;

        public Menu()
        {
            PageFactory.InitElements(Driver, this);
        }

        public void ChooseOptionInAdministration(string submenu, string item)
        {

            Actions builder = new Actions(Driver);
            builder.MoveToElement(tpAdminMenuElement).Build().Perform();
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            var clickableElement = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(submenu)));
            builder.MoveToElement(clickableElement).Build().Perform();
            wait.Until(ExpectedConditions.ElementExists(By.LinkText(item))).Click();

        }
    }
}
