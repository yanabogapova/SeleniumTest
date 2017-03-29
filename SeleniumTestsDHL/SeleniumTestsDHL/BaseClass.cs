using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTestsDHL
{
    public class BaseClass
    {
        private static readonly Lazy<IWebDriver> DriverLazy =
            new Lazy<IWebDriver>(() => new ChromeDriver());

        public static IWebDriver Driver => DriverLazy.Value;


        private static readonly Lazy<WebDriverWait> WaiterLazy =
            new Lazy<WebDriverWait>(() => new WebDriverWait(Driver, TimeSpan.FromMilliseconds(1000)));

        public static WebDriverWait Waiter => WaiterLazy.Value;
    }


}
