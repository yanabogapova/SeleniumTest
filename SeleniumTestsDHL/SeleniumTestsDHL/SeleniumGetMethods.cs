using OpenQA.Selenium;
using System;

namespace SeleniumTestsDHL
{
    class SeleniumGetMethods
    {
        public static string GetText(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
            {
                return driver.FindElement(By.Id(element)).Text;
            }

            if (elementType == "Name")
            {
                return driver.FindElement(By.Name(element)).Text;
            }
            if (elementType == "Tagname")
            {
                return driver.FindElement(By.TagName(element)).Text;
            }
            else return String.Empty;
        }
    }
}
