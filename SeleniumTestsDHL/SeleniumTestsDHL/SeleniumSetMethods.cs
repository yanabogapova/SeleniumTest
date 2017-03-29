using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTestsDHL
{
    class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }

            if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }
            if (elementType == "ClassName")
            {
                driver.FindElement(By.ClassName(element)).SendKeys(value);
            }
            if (elementType == "CssSelector")
            {
                driver.FindElement(By.CssSelector(value)).SendKeys(value);
            }
            if (elementType == "LinkText")
            {
                driver.FindElement(By.LinkText(value)).SendKeys(value);
            }
            if (elementType == "TagName")
            {
                driver.FindElement(By.TagName(value)).SendKeys(value);
            }
            if (elementType == "XPath")
            {
                driver.FindElement(By.XPath(value)).SendKeys(value);
            }


        }

        //Click
        public static void Click(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).Click();
            }

            if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).Click();
            }
            if (elementType == "ClassName")
            {
                driver.FindElement(By.ClassName(element)).Click();
            }
            if (elementType == "CssSelector")
            {
                driver.FindElement(By.CssSelector(element)).Click();
            }
            if (elementType == "LinkText")
            {
                driver.FindElement(By.LinkText(element)).Click();
            }
            if (elementType == "TagName")
            {
                driver.FindElement(By.TagName(element)).Click();
            }
            if (elementType == "XPath")
            {
                driver.FindElement(By.XPath(element)).Click();
            }

        }

        //Selecting a drop down control

        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementType)
        {

            if (elementType == "Id")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            }

            if (elementType == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            }
        }

        //JSexecutor for Kendo controls
        public static void OperateWithKendoElements(IWebDriver driver, string jsCode)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(jsCode);
        }

    }
}
