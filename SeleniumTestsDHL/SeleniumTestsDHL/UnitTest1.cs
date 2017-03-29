using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTestsDHL.Pages;
using System.Threading;
using static SeleniumTestsDHL.HelperMethod;


namespace SeleniumTestsDHL
{

    class Unit_Tests : BaseClass
    {
        [TestFixture]
        public class NTest
        {

            LoginPage loginPage = new LoginPage();
            HomePage homePage = new HomePage();
            Menu menu = new Menu();
            public void Login()
            {

                string loginPageUrl = "https://dev.evolvice.de/TPManagerDPDHLTest";
                Driver.Navigate().GoToUrl(loginPageUrl);

                loginPage.Login("tpm_admin@evolvice.de", "TaxTools!");
            }




            [Test]
            public void _1FindHomePage()
            {
                Login();

                string body = SeleniumGetMethods.GetText(Driver, "body", "Tagname");

                StringAssert.Contains("Home", body);
            }

            [Test]

            public void _2HomePageResponse()
            {
                HelperMethod.VerifyResponseCode();
            }

            [Test]
            public void _21VerifyTilesTooltipsTPcockpit()
            {
                string tooltipText = homePage.HoverTiles("TPcockpit");
                StringAssert.Contains(tooltipText, "A visual dashboard provides you with an quick regional, country or company TP overview. The multilevel module shows detailed information, such as responsible manager, transactions and next due dates");


            }
            [Test]
            public void _22VerifyTilesTooltipsTPworkflow()
            {
                string tooltipText = homePage.HoverTiles("TPworkflow");
                StringAssert.Contains(tooltipText, "This module reflects the TP documentation process and responsibilties and provides respective task manager functions such as task assigning , due date setting, delivery status tracking and setting of approvals.");


            }

            [Test]
            public void _23VerifyTilesTooltipsTPtransactions()
            {
                string tooltipText = homePage.HoverTiles("TPtransactions");
                StringAssert.Contains(tooltipText, "Get an overview of all relevant cross border transactions and respective volume. Use the integrated sort- and filter function as well as linking TPdoc storage functionality.");


            }

            [Test]
            public void _3FindTPcockpitPage()
            {

                IWebElement tile = Driver.FindElement(By.Id("TPcockpit"));
                tile.Click();
                string pageSource = Driver.PageSource;
                bool result = pageSource.Contains("TPcockpit");
                NUnit.Framework.Assert.True(result);
            }

            [Test]
            public void _4TPcockpitPageResponse()
            {
                HelperMethod.VerifyResponseCode();
            }

            [Test]
            public void _5VerifyMapView()
            {

                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                //js.ExecuteScript("$('#reportingPeriod').data('kendoDropDownList').value(3);");
                //js.ExecuteScript("$('#mapViewsCombo').data('kendoDropDownList').value(1) ;");
                //  js.ExecuteScript("$('#reportingPeriod').data('kendoDropDownList').select(3);");
                js.ExecuteScript("var dropdownlist = $('#reportingPeriod').data('kendoDropDownList'); dropdownlist.value(3); dropdownlist.trigger('change');");



                StringAssert.Contains("1", js.ExecuteScript("return $('#mapViewsCombo').data('kendoDropDownList').value();") as string);

            }

            [Test]
            public void _6FindDueDatesCockpit()
            {
                //Waiter.Until(x => x.FindElement(By.Id("DueDates")));
                Thread.Sleep(3000);
                IWebElement tileDueDates = Driver.FindElement(By.Id("DueDates"));
                tileDueDates.Click();
                string dueDatesHeader = Driver.FindElement(By.TagName("h2")).Text;
                StringAssert.Contains("Due dates Cockpit", dueDatesHeader);

            }

            [Test]
            public void _7VerifyDueDatesCockpitResponseCode()
            {
                VerifyResponseCode();
            }

            [Test]
            public void _8VerifyTPcategoryCreation()
            {
                menu.ChooseOptionInAdministration("TPcategories", "TPcategories");
            }




        }
    }
}
