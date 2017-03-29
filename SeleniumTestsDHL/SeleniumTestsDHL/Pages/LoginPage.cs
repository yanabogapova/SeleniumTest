using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTestsDHL.Pages
{
    class LoginPage : BaseClass
    {
        public LoginPage()
        {
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement EmailId { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement PasswordId { get; set; }


        [FindsBy(How = How.CssSelector, Using = "div.login .btn")]
        public IWebElement LoginButton { get; set; }


        public LoginPage Login(string email, string password)
        {
            EmailId.SendKeys(email);
            PasswordId.SendKeys(password);
            LoginButton.Click();
            return new LoginPage();
        }
    }
}
